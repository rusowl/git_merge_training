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
            long beforeNumberInMain = 1;
            long previousNumberInMain = 1;
            long expectedNumberInMain = 1;

            for (int i = 3; i <= indexOfNumber; i++)
            {
                expectedNumberInMain = beforeNumberInMain + previousNumberInMain;
                beforeNumberInMain = previousNumberInMain;
                previousNumberInMain = expectedNumberInMain;
            }

            return expectedNumberInMain;
        }
    }
}
