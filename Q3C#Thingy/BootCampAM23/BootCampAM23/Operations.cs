using System;
using System.Collections.Generic;
using System.Text;

namespace BootCampAM23
{
   public static class Operations
    {
        public static void Arithmetic()
        {
            //Use the debugger to see the values

            int a = 9;

            int b = 6;

            int c;

            a++;
            b--;

            c = a + b;

            c = a - b;

            c = a * b;

            c = a / b;

            c = a % b; //Modulo operator gives the remainder

            //n % 2 determine if something is odd or even

            a += b;// a = 15
            a -= b;

            a *= b;

            a /= 6;

        }

        public static void Comparisons()
        {
            int a = 10;
            int b = 45;
            int c = 10;
            Console.WriteLine(a == b); // == used for equality, = is assign
            Console.WriteLine(a != b);
            Console.WriteLine(a < b);



        }

        public static void Logic()
        {
            bool hasWeapon = true;
            bool hasMagic = true;
            bool hasArmor = false;


            bool isStrongOffense = hasWeapon && hasMagic; // TT = T TF=F FT = F AND command &&
            Console.WriteLine("Is Strong Offense: {0}", isStrongOffense);

            bool isOKForBattle = hasWeapon || hasArmor || hasMagic; // OR ||

            Console.WriteLine("Is OK for Battle {0}", isOKForBattle);

            // NOT operator, used for togglign !hasWeapon

            //Xor operator, exclusive OR

            bool mediumOffense = hasWeapon ^ hasMagic;
            Console.WriteLine("Has mediocre offense: {0}", mediumOffense);



        }
        public static void Ternary()
        {
            int a, b, c;

            a = 19;

            b = 5;

            c = (a > b) ? a : b; //Cryptic ternary operator, one line if statement


            Console.WriteLine(c);

            // equivalent:

            if (a > b)
            {

                c = a;


            }
            else
            {
                c = b;


            }

            int n = 8;
            string output = (n % 2 == 0) ? "EVEN" : "ODD";
            Console.WriteLine("{0} is {1}", n, output);


        }
    }
}
