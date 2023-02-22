using System;
using System.Collections.Generic;
using System.Text;

namespace CRPG
{
    public class World
    {

        public static readonly string WorldName = "Bjork";  
        public static readonly List<Location> Locations = new List<Location>();



        // STart providing IDs for locations

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_FOREST_PATH = 2;
        public const int LOCATION_ID_LAB = 3;



        // Constructor for world

        static World()
        {


            PopulateLocations();
            


        }

        private static void PopulateLocations()
        {

            //Create the location objects
            Location home = new Location(LOCATION_ID_HOME, "Home", "Your house is a mess");
            Location forestPath = new Location(LOCATION_ID_FOREST_PATH, "Forest Path", "A wooded path with lots of ferns.");
            Location lab = new Location(LOCATION_ID_LAB, "Lab", "A strange smelling lab with potions and rat tails.");

            //Link the locations together
            home.locationToNorth = forestPath;
            forestPath.locationToEast = lab;
            lab.locationToEast = forestPath;
            forestPath.locationToSouth = home;


            //Create our list of locations
            Locations.Add(home);
            Locations.Add(forestPath);
            Locations.Add(lab);
            

        }

        public static Location LocationByID(int id)
        {

            foreach (Location loc in Locations)
            {

                if(loc.ID == id)
                {

                    return loc;


                }



            }

            return null;

        }

        public static void ListLocations()
        {

            Console.WriteLine("These are the locations in the world:");
            foreach (Location loc in Locations)
            {
                Console.WriteLine("\t{0}", loc.Name);




            }


        }


    }





    
    
}
