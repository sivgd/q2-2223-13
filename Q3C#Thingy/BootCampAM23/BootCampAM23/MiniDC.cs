using System;
using System.Collections.Generic;
using System.Text;

namespace BootCampAM23
{
    public static class MiniDC
    {
       
        public static void StartDC()
        {

            bool hasVisited55 = false;

            Console.WriteLine("Welcome to Hell!");
            Console.WriteLine("What is your player's name?");
            string pName = Console.ReadLine();
            Player player = new Player(0, pName, 50,40, 12);

            //Create some beasts and scoundrels
            Player[] monster = new Player[9];
            monster[1] = new Player(1, "Steven", 20,12,7);
            monster[2] = new Player(2, "Siri", 7,1,4);
            monster[3] = new Player(3, "Alexa, What is my address?", 90,30, 13);
            monster[4] = new Player(4, "Frida the fearless", 42,20, 14);
            monster[5] = new Player(5, "Steve", 1000,100, 20);
            monster[6] = new Player(6, "Hey, Google", 8,13, 17);
            monster[7] = new Player(7, "Alexa, call the police", 700,60, 19);
            monster[8] = new Player(8, "The cringe LORD", 42,50, 14);

            // Dealing with world
            int maxX = 11;
            int maxY = 11;
            Location[,] location = new Location[maxX, maxY];
            location[5, 5] = new Location("Home", "Dark hellish home, with furniture on the ceiling", 0);
            location[4, 4] = new Location("Treasure Room", "All of hell's treasures are kept here for security, and it seems the guard is not happy with you.", 1);
            location[3, 6] = new Location("Hell Market", "This is a burgeoning makret fulll of hell's technologies, but it seems one has gone rogue", 3);
            location[4, 9] = new Location("Hell Station", "The transit area every demon uses to travel between every layer of hell", 8);
            location[7, 3] = new Location("Demonic stock market", "The place where demons invest in stocks and currency.", 7);
            location[10, 10] = new Location("The Edge", "A tourist location to look over the edge of hell, you can hear whispers within.", 5);

            // set the player loccation
            int pX = 5;
            int pY = 5;

            // create a die

            Random dice = new Random();

            //Game begins...
            while (true)
            {


                Console.WriteLine("\n--------------------------------------------------");
                Console.WriteLine("\tYour health: {0}", player.Health);
                Console.WriteLine("\tYour Location: ({0}, {1})", pX, pY);

                if (location[pX, pY] != null)
                {
                    Console.WriteLine("\t *** {0} ***", location[pX, pY].LocationName);
                    Console.WriteLine("\t ## {0} ###", location[pX, pY].Description);

                    if (location[pX, pY].MonsterID != 0)
                    {
                        int mID = location[pX, pY].MonsterID;
                        Console.WriteLine("\t !! You encounter {0} with {1} Health !!", monster[mID].Name, monster[mID].Health);
                        // battle begins here!!
                        int damageToMonster = dice.Next(1, 20);
                        int damageToPlayer = dice.Next(1, 20);

                        // Player gets hit
                        if(damageToPlayer < player.Defense)
                        {
                            
                            damageToPlayer = 0;

                        }
                        else
                        {


                            player.Health -= damageToPlayer;
                        }
                        
                        // Monster gets hit
                        if(damageToMonster < monster[mID].Defense)
                        {
                            
                            damageToMonster = 0;

                        }
                        else
                        {

                            monster[mID].Health -= damageToMonster;

                        }
                        


                        Console.WriteLine("\t\t !!! You take {0} damage! !!!", damageToPlayer);
                        Console.WriteLine("\t\t !!! {0} takes {1} damage! !!!",monster[mID].Name, damageToMonster);
                        Console.WriteLine("\t\t !!!Your health: {0} Their health: {1} !!!", player.Health, monster[mID].Health);



                        if(monster[mID].Health <= 0)
                        {

                            Console.WriteLine("\t\t !!! YOU KILL {0} !!!", monster[mID].Name);
                            Console.WriteLine("\t\t !!! YOU GET {0} COINS!!!! !!!", monster[mID].Currency);
                            player.Currency = monster[mID].Currency + player.Currency;
                            location[pX, pY].MonsterID = 0; //removes monster from room
                           // location[pX, pY] = null; //room dissapears



                        }


                        if(player.Health <=0)
                        {

                            Console.WriteLine("HAHA YOU DIED< YOU ARE CRINGE< PAY ME A DOLLAR NOW BECAUSE YOU SUCK!!!!!!!");
                                return;


                        }

                    }


                }

                if (pX == 8 && pY == 8)
                {
                    Console.WriteLine("You start to feel better!!!");
                    player.Health += dice.Next(1, 6);




                }

                if (pX == 10 && pY == 8)
                {
                    if (hasVisited55 == false)
                    {
                        Console.WriteLine("YOU FOUND A BIG PILE OF MONEY!!!!!");
                        player.Currency = player.Currency + 100;
                        hasVisited55 = true;
                    }
                    

                }


                Console.WriteLine("Your wish is my command > ");
                string cmd = Console.ReadLine().ToLower().Trim();
                if (cmd == "q" || cmd == "quit")
                {

                    Console.WriteLine("Thanks for playing, insert 25 cents to play again!");
                    return;

                }

                if (cmd == "n") pY--;
                if(cmd == "nw")
                {
                    pX--;
                    pY--;

                }
                if (cmd == "s") pY++;
                if(cmd == "sw")
                {

                    pY++;
                    pX--;

                }
                if (cmd == "e") pX++;
                if (cmd == "ne")
                {

                    pY--;
                    pX++;

                }

                if (cmd == "se")
                {

                    pY--;
                    pX++;

                }
                if (cmd == "w") pX--;

                pX = Math.Clamp(pX, 0, maxX - 1);
                pY = Math.Clamp(pY, 0, maxY - 1);

                if (cmd == "m") Location.DrawMap(location, pX, pY);

                if (cmd == "save") SaveLoadData.SavePlayerData(player);

                if (cmd == "jump") player.Jump();

                if (cmd == "I") player.ShowInventory();
                try //error trapping
                {

                    if (cmd == "load") player = SaveLoadData.LoadPlayerData(player);


                }
                catch
                {

                    Console.WriteLine("Could not restore player data.");

                }


              



            }




























        }
    }
}
