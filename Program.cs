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

                //      ------------------------------------  $ * $
                if (fraction.Contains('*'))
                {

                    string[] newFraction = fraction
                                .Split(new char[] { '/', '*'}, StringSplitOptions.RemoveEmptyEntries);

                    int number1 = int.Parse(newFraction[0]);
                    int number2 = int.Parse(newFraction[1]);

                    Fraction drop1 = new Fraction(number1, number2);

                    int number3 = int.Parse(newFraction[2]);
                    int number4 = int.Parse(newFraction[3]);

                    Fraction drop2 = new Fraction(number3, number4);

                    Console.WriteLine(drop1 * drop2);
                }
                else if (fraction.Contains('+')) // ------------------------------------   $ + $
                {
                    string[] newFraction = fraction
                                .Split(new char[] { '/', '+' }, StringSplitOptions.RemoveEmptyEntries);

                    int number1 = int.Parse(newFraction[0]);
                    int number2 = int.Parse(newFraction[1]);

                    Fraction drop1 = new Fraction(number1, number2);

                    int number3 = int.Parse(newFraction[2]);
                    int number4 = int.Parse(newFraction[3]);

                    Fraction drop2 = new Fraction(number3, number4);

                    Console.WriteLine(drop1 + drop2);
                }
                else if (fraction.Contains('-')) // ------------------------------------   $ - $
                {
                    string[] newFraction = fraction
                                .Split(new char[] { '/', '-' }, StringSplitOptions.RemoveEmptyEntries);

                    int number1 = int.Parse(newFraction[0]);
                    int number2 = int.Parse(newFraction[1]);

                    Fraction drop1 = new Fraction(number1, number2);

                    int number3 = int.Parse(newFraction[2]);
                    int number4 = int.Parse(newFraction[3]);

                    Fraction drop2 = new Fraction(number3, number4);

                    Console.WriteLine(drop1 - drop2);
                }
                else if (fraction.Contains(" < ")) // ------------------------------------   $ < $
                {
                    string[] newFraction = fraction
                                .Split(new char[] { '/', '<' }, StringSplitOptions.RemoveEmptyEntries);

                    int number1 = int.Parse(newFraction[0]);
                    int number2 = int.Parse(newFraction[1]);

                    Fraction drop1 = new Fraction(number1, number2);

                    int number3 = int.Parse(newFraction[2]);
                    int number4 = int.Parse(newFraction[3]);

                    Fraction drop2 = new Fraction(number3, number4);

                    Console.WriteLine(drop1 < drop2);
                }
                else if (fraction.Contains(" > ")) // ------------------------------------   $ > $
                {
                    string[] newFraction = fraction
                                .Split(new char[] { '/', '>' }, StringSplitOptions.RemoveEmptyEntries);

                    int number1 = int.Parse(newFraction[0]);
                    int number2 = int.Parse(newFraction[1]);

                    Fraction drop1 = new Fraction(number1, number2);

                    int number3 = int.Parse(newFraction[2]);
                    int number4 = int.Parse(newFraction[3]);

                    Fraction drop2 = new Fraction(number3, number4);

                    Console.WriteLine(drop1 > drop2);
                }
                else if (fraction.Contains("==")) // ------------------------------------   $ == $
                {
                    string[] newFraction = fraction
                                .Split(new string[] { "/", "==" }, StringSplitOptions.RemoveEmptyEntries);

                    int number1 = int.Parse(newFraction[0]);
                    int number2 = int.Parse(newFraction[1]);

                    Fraction drop1 = new Fraction(number1, number2);

                    int number3 = int.Parse(newFraction[2]);
                    int number4 = int.Parse(newFraction[3]);

                    Fraction drop2 = new Fraction(number3, number4);

                    Console.WriteLine(drop1 == drop2);
                }
                else if (fraction.Contains("<=")) // ------------------------------------   $ <= $
                {
                    string[] newFraction = fraction
                                .Split(new string[] { "/", "<=" }, StringSplitOptions.RemoveEmptyEntries);

                    int number1 = int.Parse(newFraction[0]);
                    int number2 = int.Parse(newFraction[1]);

                    Fraction drop1 = new Fraction(number1, number2);

                    int number3 = int.Parse(newFraction[2]);
                    int number4 = int.Parse(newFraction[3]);

                    Fraction drop2 = new Fraction(number3, number4);

                    Console.WriteLine(drop1 <= drop2);
                }
                else if (fraction.Contains(">=")) // ------------------------------------   $ >= $
                {
                    string[] newFraction = fraction
                                .Split(new string[] { "/", ">=" }, StringSplitOptions.RemoveEmptyEntries);

                    int number1 = int.Parse(newFraction[0]);
                    int number2 = int.Parse(newFraction[1]);

                    Fraction drop1 = new Fraction(number1, number2);

                    int number3 = int.Parse(newFraction[2]);
                    int number4 = int.Parse(newFraction[3]);

                    Fraction drop2 = new Fraction(number3, number4);

                    Console.WriteLine(drop1 >= drop2);
                }
                else if (fraction.Contains("!=")) // ------------------------------------   $ != $
                {
                    string[] newFraction = fraction
                                .Split(new string[] { "/", "!=" }, StringSplitOptions.RemoveEmptyEntries);

                    int number1 = int.Parse(newFraction[0]);
                    int number2 = int.Parse(newFraction[1]);

                    Fraction drop1 = new Fraction(number1, number2);

                    int number3 = int.Parse(newFraction[2]);
                    int number4 = int.Parse(newFraction[3]);

                    Fraction drop2 = new Fraction(number3, number4);

                    Console.WriteLine(drop1 != drop2);
                }
                else if (fraction.Contains('/')) // ------------------------------------   $ / $
                {
                    string[] newFraction = fraction
                                .Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                    int number1 = int.Parse(newFraction[0]);
                    int number2 = int.Parse(newFraction[1]);

                    Fraction drop1 = new Fraction(number1, number2);

                    int number3 = int.Parse(newFraction[2]);
                    int number4 = int.Parse(newFraction[3]);

                    Fraction drop2 = new Fraction(number3, number4);

                    Console.WriteLine(drop1 / drop2);
                }

                if (fraction == "end")
                {
                    return;
                }
            }
        }
        /*
        public static int[] TaskNew(string fraction)
        {
            string[] newFraction = fraction
            .Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            int[] nums = new int[10];

            for (int i = 0; i < newFraction.Length - 1; i++)
            {
                nums[i] = newFraction[i].Length;
            }
            return nums;
        }
        */
    }
}