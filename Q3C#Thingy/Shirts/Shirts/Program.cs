using System;

namespace Shirts
{
    class Program
    {
        static void Main(string[] args)
        {
            Shirt digiPenT = new Shirt("Black", false, "DigiPen", 4, 0, 27.5f, 100.0f, "Cotton: Preshrunk", true, true);
            digiPenT.Rip();
        }
    }
}
