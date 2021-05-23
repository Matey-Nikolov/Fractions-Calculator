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
                    string[] SplitFraction = fraction.Split(new char[] { '/', ' ' });

                    int number1 = int.Parse(SplitFraction[0]);
                    int number2 = int.Parse(SplitFraction[1]);

                    string newOperator = SplitFraction[2];

                    int number3 = int.Parse(SplitFraction[3]);
                    int number4 = int.Parse(SplitFraction[4]);

                    Fraction drop1 = new Fraction(number1, number2);
                    Fraction drop2 = new Fraction(number3, number4);



                    if (newOperator == "*") //      ------------------------------------  $ * $
                    {
                        Console.WriteLine(drop1 * drop2);
                    }
                    else if (newOperator == "+") // ------------------------------------   $ + $
                    {
                        Console.WriteLine(drop1 + drop2);
                    }
                    else if (newOperator == "-") // ------------------------------------   $ - $
                    {
                        Console.WriteLine(drop1 - drop2);
                    }
                    else if (newOperator == " < ") // ------------------------------------   $ < $
                    {
                        Console.WriteLine(drop1 < drop2);
                    }
                    else if (newOperator == " > ") // ------------------------------------   $ > $
                    {
                        Console.WriteLine(drop1 > drop2);
                    }
                    else if (newOperator == "==") // ------------------------------------   $ == $
                    {
                        Console.WriteLine(drop1 == drop2);
                    }
                    else if (newOperator == "<=") // ------------------------------------   $ <= $
                    {
                        Console.WriteLine(drop1 <= drop2);
                    }
                    else if (newOperator == ">=") // ------------------------------------   $ >= $
                    {
                        Console.WriteLine(drop1 >= drop2);
                    }
                    else if (newOperator == "!=") // ------------------------------------   $ != $
                    {
                        Console.WriteLine(drop1 != drop2);
                    }
                    else if (newOperator == "/") // ------------------------------------   $ / $
                    {
                        Console.WriteLine(drop1 / drop2);
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