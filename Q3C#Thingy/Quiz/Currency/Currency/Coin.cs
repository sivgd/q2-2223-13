using System;
using System.Collections.Generic;
using System.Text;

namespace Currency
{
   public class Coin
    {
        string Name;
        string Nationality;
        string FaceOnCoin;
        int ValueInCents;
        float PercentOfDollar;
        int CoinSide;
        string Color;
        bool IsShiny;

        Random dice = new Random();


        public Coin()
        {



        }

        public Coin(string name, string nationality, string faceOnCoin, int valueInCents, float percentOfDollar, int coinSide, string color, bool isShiny)
        {
            Name = name;
            Nationality = nationality;
            FaceOnCoin = faceOnCoin;
            ValueInCents = valueInCents;
            PercentOfDollar = percentOfDollar;
            CoinSide = coinSide;
            Color = color;
            IsShiny = isShiny; 
        }

        
        public void Flip()
        {

            CoinSide = dice.Next(1, 2);

            if (CoinSide == 1)
            {

                Console.WriteLine("The {0} flipped to Heads!", Name);


            }
            else
            {

                Console.WriteLine("The {0} flipped to tails!", Name);


            }



        }


        public void Clean()
        {

            if(IsShiny == false)
            {
                Console.WriteLine("You clean the {0}, it is shiny and new!", Name);



            }
            else
            {

                Console.WriteLine("The {0} is already clean!", Name);
                return;

            }


            
        }

        public void Throw()
        {

            Console.WriteLine("You throw the coin! Never seeing that again!");
            return;


        }
    }
}
