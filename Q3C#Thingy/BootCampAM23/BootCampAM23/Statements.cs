using System;
using System.Collections.Generic;
using System.Text;

namespace BootCampAM23
{
   public static class Statements
    {

        public static void BranchingIf()// notice no semicolons
        {
            int a = 42; //try changing this.....
            if(a < 4)
            {// code block between curly braces{}

                Console.WriteLine("a is less than 4");
                Console.WriteLine("================================");





            }else if (a >= 4 && a <= 10)
            {

                Console.WriteLine("A is between 4 and 10 (inclusive)");
                Console.WriteLine("********************************************");




            }
            else
            {

                Console.WriteLine("a is larger than 10......");
                Console.WriteLine("----------------------------------");



            }


            int b = 2;
            if (b < 10)
                Console.WriteLine("B is less than 10.");
            //if only one line of code is run, NO CURLY BRACES NECESSARY



        }

        public static void Switching()
        {
            int d = 5; // try changing this
            string day = "";


            switch(d%7)//no semicolon here!
            {

                case 1: // Colon not semicolon
                    day = "Monday";

                    break;

                case 2:
                 day = "Tuesday";
                    break;

                    case 3:
                    day = "Wednesday";
                    break;


                case 4:
                    day = "Thursday";
                    break;

                case 5:
                    day = "Friday";
                    break;

                default:
                    day = "A weekend day";
                    break;

                    



            }

            Console.WriteLine("Day {0} is {1}", d, day);


        }
        public static void ForLoop()
        {

            // For (Initializer; test-expression; updater) {  }

            for(int i = 0; i < 10; i++)// count up by ones from 0 to 9
            {

                Console.WriteLine("i={0}", i);

            }

            //nested for loops.....

        }

        public static void WhileLoops()
        {

            // While (test-expression ==true) { }

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("i = {0}", i);
                i++;



            }
            //do whie loop, test takes place at the endS
            int j = 0;

            do
            {


                Console.WriteLine("j = {0}", j);
                j++;


            } while (j < 5);

            do
            {
                Console.Write("Command: > ");



            } while (Console.ReadLine()  != "q");

        }
        public static void ForEachLoops()
        {

            List<string> phones = new List<string>();
            phones.Add(" iphone 14");
            phones.Add("Samsung Galaxy");
            phones.Add("Motorola Stylus");
            phones.Add("Google Pixel");
            phones.Add("T-mobile Flip Phone");
            phones.Sort();
            phones.Remove("Nokia");

            foreach( string p in phones)
            {

                Console.WriteLine("you take out your {0}", p);


            }




        }


    }
}
