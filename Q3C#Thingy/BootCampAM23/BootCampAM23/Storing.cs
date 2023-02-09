using System;
using System.Collections.Generic;
using System.Text;

namespace BootCampAM23
{
    public static class Storing //static means it only holds code... not for an object!
    {
        //Making a method...
        public static void DemoVariables()
        {
            int employeeID = 42; //whole numbers, no decimals
            uint income = 78; //unsigned.... only positive!
            long bigNumber = 347892378792347982;
            float pi = 3.14159f;  //can also use double or decimal
            string employeeName = "Jim"; //store up to 2GB
            bool isRich = false; //true or false
            char firstInitial = 'J';

            income++;
            firstInitial++;


            Console.WriteLine("Your name is {0} and your first initial is {1} and your income is {2}", employeeName, firstInitial, income);

        }


        public static void ReadingInput()
        {
            Console.WriteLine("What is your name?");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Hello {0}. Welcome to Microsoft!!", employeeName);
            Console.WriteLine("How old are you, in Years?");
            int age = Convert.ToInt32 ( Console.ReadLine());
            Console.WriteLine("You are {0} Years Old", age);
            int ageInMonths = age * 12;
            Console.WriteLine("You are {0} Months Old", ageInMonths);
            //Variable Names
            // camelCaseVariableNAme ( fist letter lowercase, the rest Uppercase)
            //PascalCaseVariableName ( All letters uppercase)
        }
        public static void UsingArrays()
        {
            string[] enemyName = new string[6];

            enemyName[0] = "Sneaker";
            enemyName[1] = "Logan the Lonely";
            enemyName[2] = "Jonathan The Joker";
            enemyName[3] = "Tayton the Tenderizer";
            enemyName[4] = "Jim the Jiant";
            enemyName[5] = "Casey the Cringe";

            int[] health = new int[6];
            health[0] = 20;
            health[1] = 5;
            health[2] = 1;
            health[3] = 100;
            health[4] = 1000;
            health[5] = 1000000;


            System.Random random = new System.Random();




            while (true)
            {

                int num = random.Next(6);
                Console.WriteLine(enemyName[num]);
                health[num]--;
                if(health[num] <= 0)
                
                {
                    Console.WriteLine("DEAD!!!!!");

                 }
                Console.WriteLine("Health: {0}", health[num]);
                Console.ReadKey();
            }
            
            




        }
    }



}
