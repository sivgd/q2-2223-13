using System;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {

            Coin CanadianDollar = new Coin("Canadian Dollar", "Canadian", "Queen Elizabeth", 712, 0.00744625f, 1, "Gold", false);
            CanadianDollar.Clean();

            Coin Peso = new Coin("Peso", "Mexican", "Eagle", 1000, 0.000510205f, 2, "Gold", false);
            Peso.Flip();
            Peso.Throw();

        }
    }
}
