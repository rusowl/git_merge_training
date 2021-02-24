using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            uint indexOfNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine(CalcFibonacciRenamedInD(indexOfNumber));
        }

        private static long CalcFibonacciRenamedInD(uint indexOfNumber)
        {
            if (indexOfNumber == 0)
            {
                return 0;
            }

            if (indexOfNumber <= 2)
            {
                return 1;
            }
            long beforeNumberInD = 1;
            long previousNumberInD = 1;
            long expectedNumberInD = 1;

            for (int i = 3; i <= indexOfNumber; i++)
            {
                expectedNumberInD = beforeNumberInD + previousNumberInD;
                beforeNumberInD = previousNumberInD;
                previousNumberInD = expectedNumberInD;
            }

            return expectedNumberInD;
        }
    }
}
