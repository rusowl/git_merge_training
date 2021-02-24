using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            uint indexOfNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine(CalcFibonacci(indexOfNumber));
        }

        private static long CalcFibonacci(uint indexOfNumber)
        {
            if (indexOfNumber == 0)
            {
                return 0;
            }

            if (indexOfNumber <= 2)
            {
                return 1;
            }
            long before = 1;
            long previous = 1;
            long expected = 1;

            for (int i = 3; i <= indexOfNumber; i++)
            {
                expected = before + previous;
                before = previous;
                previous = expected;
            }

            return expected;
        }
    }
}
