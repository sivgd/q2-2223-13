using System;

namespace CupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Cup snoIsleCup = new Cup("Sno Isle Cup", true, false, 0, "None", 10.5f, "White", "Ceramic", true, false, 9, true);

            snoIsleCup.Drink();
        }
    }
}
