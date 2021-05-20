using System;

namespace Fractions
{
    class Program
    {
        static void Main()
        {
            /*
            Fraction drob1 = new Fraction(5, 6);
            Fraction drob2 = new Fraction(1, 3);

            Fraction drob3 = drob1 + drob2;
            Console.WriteLine(drob3);
            */
            Fraction drob1 = new Fraction("1/3");
            Fraction drob2 = new Fraction(2, 5);

            Console.WriteLine(drob1 == drob2);
        }
    }
}
