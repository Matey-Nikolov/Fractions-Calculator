using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Split
    {
        public static Fraction SplitByMultiplication(string oldFraction)
        {
            string[] newFraction = oldFraction
                        .Split(new char[] { '/', '*' }, StringSplitOptions.RemoveEmptyEntries);

            int number1 = int.Parse(newFraction[0]);
            int number2 = int.Parse(newFraction[1]);

            Fraction drop1 = new Fraction(number1, number2);

            int number3 = int.Parse(newFraction[2]);
            int number4 = int.Parse(newFraction[3]);

            Fraction drop2 = new Fraction(number3, number4);

            return drop1 * drop2;
        }

        public static Fraction SplitByPlus(string oldFraction)
        {
            string[] newFraction = oldFraction
            .Split(new char[] { '/', '+' }, StringSplitOptions.RemoveEmptyEntries);

            int number1 = int.Parse(newFraction[0]);
            int number2 = int.Parse(newFraction[1]);

            Fraction drop1 = new Fraction(number1, number2);

            int number3 = int.Parse(newFraction[2]);
            int number4 = int.Parse(newFraction[3]);

            Fraction drop2 = new Fraction(number3, number4);

            return drop1 + drop2;
        }

        public static Fraction SplitByPlusMinus(string oldFraction)
        {
            string[] newFraction = oldFraction
            .Split(new char[] { '/', '-' }, StringSplitOptions.RemoveEmptyEntries);

            int number1 = int.Parse(newFraction[0]);
            int number2 = int.Parse(newFraction[1]);

            Fraction drop1 = new Fraction(number1, number2);

            int number3 = int.Parse(newFraction[2]);
            int number4 = int.Parse(newFraction[3]);

            Fraction drop2 = new Fraction(number3, number4);

            return drop1 - drop2;
        }

        public static bool SplitBylessOperation(string oldFraction)
        {
            string[] newFraction = oldFraction
            .Split(new char[] { '/', '<' }, StringSplitOptions.RemoveEmptyEntries);

            int number1 = int.Parse(newFraction[0]);
            int number2 = int.Parse(newFraction[1]);

            Fraction drop1 = new Fraction(number1, number2);

            int number3 = int.Parse(newFraction[2]);
            int number4 = int.Parse(newFraction[3]);

            Fraction drop2 = new Fraction(number3, number4);

            return drop1 < drop2;
        }

        public static bool SplitByBiggerOperation(string oldFraction)
        {
            string[] newFraction = oldFraction
            .Split(new char[] { '/', '>' }, StringSplitOptions.RemoveEmptyEntries);

            int number1 = int.Parse(newFraction[0]);
            int number2 = int.Parse(newFraction[1]);

            Fraction drop1 = new Fraction(number1, number2);

            int number3 = int.Parse(newFraction[2]);
            int number4 = int.Parse(newFraction[3]);

            Fraction drop2 = new Fraction(number3, number4);

            return drop1 > drop2;
        }

        public static bool SplitBy__Operation(string oldFraction)
        {
            string[] newFraction = oldFraction
                        .Split(new string[] { "/", "==" }, StringSplitOptions.RemoveEmptyEntries);

            int number1 = int.Parse(newFraction[0]);
            int number2 = int.Parse(newFraction[1]);

            Fraction drop1 = new Fraction(number1, number2);

            int number3 = int.Parse(newFraction[2]);
            int number4 = int.Parse(newFraction[3]);

            Fraction drop2 = new Fraction(number3, number4);

            return drop1 == drop2;
        }

        public static bool SplitByLessThanOrEqual(string oldFraction)
        {
            string[] newFraction = oldFraction
            .Split(new string[] { "/", "<=" }, StringSplitOptions.RemoveEmptyEntries);

            int number1 = int.Parse(newFraction[0]);
            int number2 = int.Parse(newFraction[1]);

            Fraction drop1 = new Fraction(number1, number2);

            int number3 = int.Parse(newFraction[2]);
            int number4 = int.Parse(newFraction[3]);

            Fraction drop2 = new Fraction(number3, number4);

            return drop1 <= drop2;
        }

        public static bool SplitByBiggerThanOrEqual(string oldFraction)
        {
            string[] newFraction = oldFraction
                        .Split(new string[] { "/", ">=" }, StringSplitOptions.RemoveEmptyEntries);

            int number1 = int.Parse(newFraction[0]);
            int number2 = int.Parse(newFraction[1]);

            Fraction drop1 = new Fraction(number1, number2);

            int number3 = int.Parse(newFraction[2]);
            int number4 = int.Parse(newFraction[3]);

            Fraction drop2 = new Fraction(number3, number4);

            return drop1 >= drop2;
        }

        public static bool SplitByNotEqual(string oldFraction)
        {
            string[] newFraction = oldFraction
                        .Split(new string[] { "/", "!=" }, StringSplitOptions.RemoveEmptyEntries);

            int number1 = int.Parse(newFraction[0]);
            int number2 = int.Parse(newFraction[1]);

            Fraction drop1 = new Fraction(number1, number2);

            int number3 = int.Parse(newFraction[2]);
            int number4 = int.Parse(newFraction[3]);

            Fraction drop2 = new Fraction(number3, number4);

            return drop1 >= drop2;
        }

        public static Fraction SplitByDivision(string oldFraction)
        {
            string[] newFraction = oldFraction
            .Split('/', StringSplitOptions.RemoveEmptyEntries);

            int number1 = int.Parse(newFraction[0]);
            int number2 = int.Parse(newFraction[1]);

            Fraction drop1 = new Fraction(number1, number2);

            int number3 = int.Parse(newFraction[2]);
            int number4 = int.Parse(newFraction[3]);

            Fraction drop2 = new Fraction(number3, number4);

            return drop1 / drop2;
        }
    }
}
