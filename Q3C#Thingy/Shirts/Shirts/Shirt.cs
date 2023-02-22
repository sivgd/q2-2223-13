using System;
using System.Collections.Generic;
using System.Text;

namespace Shirts
{
    public class Shirt
    {
        //Properties, Members
        public string Color;
        public bool IsLongSleeved;
        public string LogoText;
        public int Holes;
        public int NumberOfButtons;
        public float ShirtLength;
        public float PercentCotton;
        public string Material;
        public bool IsMachineWashable;
        public bool IsSchoolAppropriate;

        //2 Constructors
        public Shirt()
        {






        }

        public Shirt(string color, bool isLongSleeved, string logoText, int holes, int numberOfButtons, float shirtLength, float percentCotton, string material, bool isMachineWashable, bool isSchoolAppropriate)
        {
            Color = color;
            IsLongSleeved = isLongSleeved;
            LogoText = logoText;
            Holes = holes;
            NumberOfButtons = numberOfButtons;
            ShirtLength = shirtLength;
            PercentCotton = percentCotton;
            Material = material;
            IsMachineWashable = isMachineWashable;
            IsSchoolAppropriate = isSchoolAppropriate;

           
       
        
        
        
        }

        //Methods

        public void Rip()
        {

            Holes++;
            Console.WriteLine("You ripped the {0} shirt, now it had {1} holes!", LogoText, Holes);

        }
    }
}
