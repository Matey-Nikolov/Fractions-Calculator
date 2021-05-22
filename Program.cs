using System;
using System.Text.RegularExpressions;

namespace Fractions
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string fraction = Console.ReadLine();

                Regex rg = new Regex(@"\d{1,}\/[1-9]{1,} ((!=)|(<=)|(>=)|(==)|(<)|(>)|(\+)|(-)|(\/)|(\*)) \d{1,}\/[1-9]{1,}");


                if (fraction == "END" || fraction == "end")
                {
                    return;
                }

                if (rg.IsMatch(fraction))
                {
                    
                    if (fraction.Contains('*')) //      ------------------------------------  $ * $
                    {
                        Console.WriteLine(Split.SplitByMultiplication(fraction));
                    }
                    else if (fraction.Contains('+')) // ------------------------------------   $ + $
                    {
                        Console.WriteLine(Split.SplitByPlus(fraction));
                    }
                    else if (fraction.Contains('-')) // ------------------------------------   $ - $
                    {
                        Console.WriteLine(Split.SplitByPlusMinus(fraction));
                    }
                    else if (fraction.Contains(" < ")) // ------------------------------------   $ < $
                    {
                        Console.WriteLine(Split.SplitBylessOperation(fraction));
                    }
                    else if (fraction.Contains(" > ")) // ------------------------------------   $ > $
                    {
                        Console.WriteLine(Split.SplitByBiggerOperation(fraction));
                    }
                    else if (fraction.Contains("==")) // ------------------------------------   $ == $
                    {
                        Console.WriteLine(Split.SplitBy__Operation(fraction));
                    }
                    else if (fraction.Contains("<=")) // ------------------------------------   $ <= $
                    {
                        Console.WriteLine(Split.SplitByLessThanOrEqual(fraction));
                    }
                    else if (fraction.Contains(">=")) // ------------------------------------   $ >= $
                    {
                        Console.WriteLine(Split.SplitByBiggerThanOrEqual(fraction));
                    }
                    else if (fraction.Contains("!=")) // ------------------------------------   $ != $
                    {
                        Console.WriteLine(Split.SplitByNotEqual(fraction));
                    }
                    else if (fraction.Contains('/')) // ------------------------------------   $ / $
                    {
                        Console.WriteLine(Split.SplitByDivision(fraction));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid expression. Try again.");
                    continue;
                }
            }
        }
    }
}