using System;
using System.Collections.Generic;
using System.Text;

namespace CRPG
{
    public class Location
    {

        public int ID;
        public string Name;
        public string Description;
        public Location locationToNorth;
        public Location locationToEast;
        public Location locationToSouth;
        public Location locationToWest;


        //Constructor
        public Location(int iD, string name, string description)
        {
            ID = iD;
            Name = name;
            Description = description;
        }




        








    }
}
