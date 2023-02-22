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
            int playerID = 42; //whole numbers, no decimals
            uint XP = 78; //unsigned.... only positive!
            long bigNumber = 347892378792347982;
            float pi = 3.14159f;  //can also use double or decimal
            string playerName = "Jim"; //store up to 2GB
            bool isRich = false; //true or false
            char firstInitial = 'J';

            XP++;
            firstInitial++;


            Console.WriteLine("Your name is {0} and your first initial is {1} and your income is {2}", playerName, firstInitial, XP);

        }


        public static void ReadingInput()
        {
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Hello {0}. Care to buy some weaponry?", playerName);
            Console.WriteLine("How much XP do you have??");
            int XP = Convert.ToInt32 ( Console.ReadLine());
            Console.WriteLine("You have {0} XP", XP);
            int XPInGold = XP * 12;
            Console.WriteLine("That translates {0} Gold! ", XPInGold);
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
