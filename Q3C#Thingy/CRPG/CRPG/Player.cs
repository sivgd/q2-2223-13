using System;
using System.Collections.Generic;
using System.Text;

namespace CRPG
{
    class Player
    {

        public string Name{ set; get; }
        public Location CurrentLocation { set; get; }


        public void MoveTo(Location loc)
        {
            CurrentLocation = loc;




        }
        public void MoveNorth()
        {

            if(CurrentLocation.locationToNorth != null)
            {
                MoveTo(CurrentLocation.locationToNorth);


            }
            else
            {


                Console.WriteLine("You cannot move north.");

            }


        }

        public void MoveEast()
        {

            if (CurrentLocation.locationToEast != null)
            {
                MoveTo(CurrentLocation.locationToEast);


            }
            else
            {


                Console.WriteLine("You cannot move east.");

            }


        }

        public void MoveSouth()
        {

            if (CurrentLocation.locationToSouth != null)
            {
                MoveTo(CurrentLocation.locationToSouth);


            }
            else
            {


                Console.WriteLine("You cannot move south.");

            }


        }


        public void MoveWest()
        {

            if (CurrentLocation.locationToWest != null)
            {
                MoveTo(CurrentLocation.locationToWest);


            }
            else
            {


                Console.WriteLine("You cannot move west.");

            }


        }


    }
}
