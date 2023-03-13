using System;
using System.Collections.Generic;
using System.Text;

namespace BootCampAM23
{
   public class Player
    {

        public int ID { get; set; } //Assign 0 to actual player, monsters are other IDs
        public string Name { get; set; }
        public int Health { get; set; }

        public int Defense;

        public int Currency;
        //Jim is asking to customize. speed. inventory, XP

        public Player()
        {




        }

        public Player(int iD, string name, int health, int defense, int currency)
        {
            ID = iD;
            Name = name;
            Health = health;
            Defense = defense;
            Currency = currency;
        }


        public void Jump()
        {
            Console.WriteLine("You jump up and down. It is actually a little endearing.");



        }

        public void ShowInventory()
        {

            Console.WriteLine("You have {0} coins!", Currency);



        }

    }
}
