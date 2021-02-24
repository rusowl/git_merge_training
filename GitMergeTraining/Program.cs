using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            uint indexOfNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine(CalcFibonacciRemanedInC(indexOfNumber));
        }

        private static long CalcFibonacciRemanedInC(uint indexOfNumber)
        {
            if (indexOfNumber == 0)
            {
                return 0;
            }

            if (indexOfNumber <= 2)
            {
                return 1;
            }
            long beforeNumberInC = 1;
            long previousNumberInC = 1;
            long expectedNumberInC = 1;

            for (int i = 3; i <= indexOfNumber; i++)
            {
                expectedNumberInC = beforeNumberInC + previousNumberInC;
                beforeNumberInC = previousNumberInC;
                previousNumberInC = expectedNumberInC;
            }

            return expectedNumberInC;
        }
    }
}
