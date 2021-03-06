using System;
using System.Text.RegularExpressions;

namespace Fractions
{
    class Program
    {
        static void Main()
        {
            int number1;
            int number2;
            int number3;
            int number4;
            string newOperator;

            while (true)
            {
                string fraction = Console.ReadLine();

                Regex rg = new Regex(@"\d{1,}\/[1-9]+[0-9]* ((!=)|(<=)|(>=)|(==)|(<)|(>)|(\+)|(-)|(\/)|(\*)) \d{1,}\/[1-9]+[0-9]*");

                if (fraction == "END" || fraction == "end")
                {
                    return;
                }

                if (rg.IsMatch(fraction))
                {
                    string[] SplitFraction = fraction.Split(new char[] { '/', ' ' });

                    number1 = int.Parse(SplitFraction[0]);
                    number2 = int.Parse(SplitFraction[1]);

                    if (SplitFraction[2] == "")
                    {
                        newOperator = "/";
                        number3 = int.Parse(SplitFraction[4]);
                        number4 = int.Parse(SplitFraction[5]);
                    }
                    else
                    {
                        newOperator = SplitFraction[2];
                        number3 = int.Parse(SplitFraction[3]);
                        number4 = int.Parse(SplitFraction[4]);
                    }

                    Fraction drop1 = new Fraction(number1, number2);
                    Fraction drop2 = new Fraction(number3, number4);

                    if (newOperator == "*") //      ------------------------------------  $ * $
                    {
                        Console.WriteLine(drop1 * drop2);
                        Console.WriteLine((drop1 * drop2).NormalToString());
                    }
                    else if (newOperator == "+") // ------------------------------------   $ + $
                    {
                        Console.WriteLine(drop1 + drop2);
                        Console.WriteLine((drop1 + drop2).NormalToString());
                    }
                    else if (newOperator == "-") // ------------------------------------   $ - $
                    {
                        Console.WriteLine(drop1 - drop2);
                        Console.WriteLine((drop1 - drop2).NormalToString());
                    }
                    else if (newOperator == "<") // ------------------------------------   $ < $
                    {
                        Console.WriteLine(drop1 < drop2);
                    }
                    else if (newOperator == ">") // ------------------------------------   $ > $
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
                        Console.WriteLine((drop1 / drop2).NormalToString());
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