using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var resultOfTwoPlusTwo = SumTwoValues(2, 2);

            Console.WriteLine($"2 + 2 is {resultOfTwoPlusTwo}");

            var resultOfFivePerThree = GetRestOfDivisionOfTwoNumber(5, 3);

            Console.WriteLine($"The rest of 5 / 3 is {resultOfFivePerThree}");

        }

        static int SumTwoValues(int value1, int value2)
        {
            return value1 + ++value2;
        }

        static int GetRestOfDivisionOfTwoNumber(int dividend, int divisor)
        {
            int result;

            Math.DivRem(dividend, divisor, out result);

            return result;
        }
    }
}
