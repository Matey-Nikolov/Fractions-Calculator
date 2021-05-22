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

                Regex rg = new Regex(@"[\d]{1,}\/[1-9]{1,} ((!=)?|(<=)?|(>=)?|(==)?|(<)?|(>)?|(\+)|(-)|(\/)|(\*))? [\d]{1,}\/[1-9]{1,}");


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
                        /*
                        string[] newFraction = fraction
                                    .Split(new char[] { '/', '<' }, StringSplitOptions.RemoveEmptyEntries);

                        int number1 = int.Parse(newFraction[0]);
                        int number2 = int.Parse(newFraction[1]);

                        Fraction drop1 = new Fraction(number1, number2);

                        int number3 = int.Parse(newFraction[2]);
                        int number4 = int.Parse(newFraction[3]);

                        Fraction drop2 = new Fraction(number3, number4);
                        */
                        Console.WriteLine(Split.SplitBylessOperation(fraction));
                    }
                    else if (fraction.Contains(" > ")) // ------------------------------------   $ > $
                    {
                        /*
                        string[] newFraction = fraction
                                    .Split(new char[] { '/', '>' }, StringSplitOptions.RemoveEmptyEntries);

                        int number1 = int.Parse(newFraction[0]);
                        int number2 = int.Parse(newFraction[1]);

                        Fraction drop1 = new Fraction(number1, number2);

                        int number3 = int.Parse(newFraction[2]);
                        int number4 = int.Parse(newFraction[3]);

                        Fraction drop2 = new Fraction(number3, number4);
                        */
                        Console.WriteLine(Split.SplitByBiggerOperation(fraction));
                    }
                    else if (fraction.Contains("==")) // ------------------------------------   $ == $
                    {
                        /*
                        string[] newFraction = fraction
                                    .Split(new string[] { "/", "==" }, StringSplitOptions.RemoveEmptyEntries);

                        int number1 = int.Parse(newFraction[0]);
                        int number2 = int.Parse(newFraction[1]);

                        Fraction drop1 = new Fraction(number1, number2);

                        int number3 = int.Parse(newFraction[2]);
                        int number4 = int.Parse(newFraction[3]);

                        Fraction drop2 = new Fraction(number3, number4);
                        */
                        Console.WriteLine(Split.SplitBy__Operation(fraction));
                    }
                    else if (fraction.Contains("<=")) // ------------------------------------   $ <= $
                    {
                        /*
                        string[] newFraction = fraction
                                    .Split(new string[] { "/", "<=" }, StringSplitOptions.RemoveEmptyEntries);

                        int number1 = int.Parse(newFraction[0]);
                        int number2 = int.Parse(newFraction[1]);

                        Fraction drop1 = new Fraction(number1, number2);

                        int number3 = int.Parse(newFraction[2]);
                        int number4 = int.Parse(newFraction[3]);

                        Fraction drop2 = new Fraction(number3, number4);
                        */
                        Console.WriteLine(Split.SplitByLessThanOrEqual(fraction));
                    }
                    else if (fraction.Contains(">=")) // ------------------------------------   $ >= $
                    {
                        /*
                        string[] newFraction = fraction
                                    .Split(new string[] { "/", ">=" }, StringSplitOptions.RemoveEmptyEntries);

                        int number1 = int.Parse(newFraction[0]);
                        int number2 = int.Parse(newFraction[1]);

                        Fraction drop1 = new Fraction(number1, number2);

                        int number3 = int.Parse(newFraction[2]);
                        int number4 = int.Parse(newFraction[3]);

                        Fraction drop2 = new Fraction(number3, number4);
                        */
                        Console.WriteLine(Split.SplitByBiggerThanOrEqual(fraction));
                    }
                    else if (fraction.Contains("!=")) // ------------------------------------   $ != $
                    {
                        /*
                        string[] newFraction = fraction
                                    .Split(new string[] { "/", "!=" }, StringSplitOptions.RemoveEmptyEntries);

                        int number1 = int.Parse(newFraction[0]);
                        int number2 = int.Parse(newFraction[1]);

                        Fraction drop1 = new Fraction(number1, number2);

                        int number3 = int.Parse(newFraction[2]);
                        int number4 = int.Parse(newFraction[3]);

                        Fraction drop2 = new Fraction(number3, number4);
                        */
                        Console.WriteLine(Split.SplitByNotEqual(fraction));
                    }
                    else if (fraction.Contains('/')) // ------------------------------------   $ / $
                    {
                        /*
                        string[] newFraction = fraction
                                    .Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                        int number1 = int.Parse(newFraction[0]);
                        int number2 = int.Parse(newFraction[1]);

                        Fraction drop1 = new Fraction(number1, number2);

                        int number3 = int.Parse(newFraction[2]);
                        int number4 = int.Parse(newFraction[3]);

                        Fraction drop2 = new Fraction(number3, number4);
                        */
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