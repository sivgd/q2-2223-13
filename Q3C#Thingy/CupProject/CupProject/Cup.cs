using System;
using System.Collections.Generic;
using System.Text;

namespace CupProject
{
    public class Cup
    {
        public string Name;
        public bool HasHandle;
        public bool HasLiquid;
        public int VolumeOfLiquid;
        public string TypeOfLiquid;
        public float Circumference;
        public string Color;
        public string Material;
        public bool IsBranded;
        public bool IsDamaged;
        public int Height;
        public bool IsClean;

        public Cup(string name, bool hasHandle, bool hasLiquid, int volumeOfLiquid, string typeOfLiquid, float circumference, string color, string material, bool isBranded, bool isDamaged, int height, bool isClean)
        {
            Name = name;
            HasHandle = hasHandle;
            HasLiquid = hasLiquid;
            VolumeOfLiquid = volumeOfLiquid;
            TypeOfLiquid = typeOfLiquid;
            Circumference = circumference;
            Color = color;
            Material = material;
            IsBranded = isBranded;
            IsDamaged = isDamaged;
            Height = height;
            IsClean = isClean;
        }

        public void Drink()
        {

            

            VolumeOfLiquid--;
            Console.WriteLine("You drank from {0}, you now have {1} ml left of {2}", Name, VolumeOfLiquid, TypeOfLiquid );

            if (VolumeOfLiquid <= 0)
            {

                Console.WriteLine("{0} is empty! you can't drink air!", Name);
                return;



            }



        }

        public void Clean()
        {
            if ( IsClean == true)
            {

                Console.WriteLine("{0} is already clean!", Name);
                return;



            }
            if (IsDamaged == true)
            {

                Console.WriteLine("{0} is broken! The only thing you can clean is the mess!", Name);
                return;


            }

            Console.WriteLine("You clean {0}, it is now shining!", Name);
            IsClean = true;

        }


    }
}
