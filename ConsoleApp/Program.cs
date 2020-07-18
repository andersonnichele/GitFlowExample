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

            var resultOfTwoTimesTwo = MultiplyTwoNumbers(2, 2);

            Console.WriteLine($"2 * 2 is {resultOfTwoTimesTwo}");
        }

        static int SumTwoValues(int value1, int value2)
        {
            return value1 + value2;
        }

        static int MultiplyTwoNumbers(int value1, int value2)
        {
            return value1 * value2;
        }
    }
}
