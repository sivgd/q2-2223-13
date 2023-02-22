﻿using System;


//Rafael Gefter 2005
namespace CRPG
{
    class Program
    {


        private static Player _player = new Player();
        static void Main(string[] args)
        {
            GameEngine.Initialize();
            _player.Name = "Fred the Fearless";
            _player.MoveTo(World.LocationByID(World.LOCATION_ID_HOME));

            while (true)
            {
                Console.Write("> ");
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {

                    continue;


                }
                string cleanedInput = userInput.ToLower();
                if(cleanedInput == "exit")
                {
                    break;


                }


                ParseInput(cleanedInput);
            }
            // while 
            
        }//Main

        public static void ParseInput(string input)
        {

            if (input.Contains("help"))
            {


                Console.WriteLine("Help is coming later...stay tuned.");


            } else if(input.Contains("look")) {
                DisplayCurrentLocation();




            }
            else if (input.Contains("north"))
            {

                _player.MoveNorth();


            } else if (input.Contains("east"))
            {

                _player.MoveEast();


            }
            else if (input.Contains("south"))
            {

                _player.MoveSouth();


            }
            else if (input.Contains("west"))
            {

                _player.MoveWest();


            }
             else
            {
                Console.WriteLine("I don't understand. Sorry!");



            }



        }//ParseInput


        private static void DisplayCurrentLocation()
        {

            Console.WriteLine("You are at: {0}", _player.CurrentLocation.Name);
            if(_player.CurrentLocation.Description != "")
            {
                Console.Write("\t{0}\n", _player.CurrentLocation.Description);




            }



        }
    }
}
