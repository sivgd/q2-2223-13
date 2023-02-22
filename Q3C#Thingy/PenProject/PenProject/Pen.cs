using System;
using System.Collections.Generic;
using System.Text;

namespace PenProject
{
    public class Pen //used to create pen objects
    {

        public string Name;
        public string Color;
        public bool HasCap;
        public bool isEmpty;
        public float Length;
        public float Price;
        public int NumberPerBox;
        public float InkLevelPercent;
        //Constructors

        public Pen()
        {
            


        }

        public Pen(string name, string color, bool hasCap, bool isEmpty, float length, float price, int numberPerBox, float inkLevelPercent)
        {
            Name = name;
            Color = color;
            HasCap = hasCap;
            this.isEmpty = isEmpty;
            Length = length;
            Price = price;
            NumberPerBox = numberPerBox;
            InkLevelPercent = inkLevelPercent;
        }


        //Methods(verbs or actions)
        public void Uncap()
        {
            HasCap = false;
            Console.WriteLine("{0} has been uncapped!", Name);
        }


        public void Cap()
        {
            HasCap = true;
            Console.WriteLine("The cap has been put on {0}!", Name);
        }
        public void Throw()
        {
           
            Console.WriteLine("You Threw {0}, {1} ink is on the floor now!", Name, Color);
            Uncap();
        }
        public void Write()
        {
            if (HasCap == true)
            {

                Console.WriteLine("You cannot write with {0}, the cap is still on!", Name);
                return;


            }
            if(InkLevelPercent <= 0)
            {

                Console.WriteLine("YOU HAVE NO INK LEFT!!!");
                return;


            }
            Console.WriteLine("{0} Writes Hello World on paper in {1} ink!", Name, Color);
            InkLevelPercent--;

        }
        public void CheckInkLevel()
        {
            Console.WriteLine("{0} has {1}% ink remaining!", Name, InkLevelPercent);

        }

    }
}
