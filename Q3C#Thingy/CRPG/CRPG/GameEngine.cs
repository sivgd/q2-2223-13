﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRPG
{
   public static class GameEngine
    {
        public static string Version = "0.0.2";




        public static void Initialize()
        {
            Console.WriteLine("Initializing Game Engine Version {0}", Version);
            Console.WriteLine("\n\nWelcome to the world of {0}.", World.WorldName);
            Console.WriteLine();
            World.ListLocations();

        }
    }

}
