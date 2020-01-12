using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Easy
{
    class FibonacciEvenSumSolution
    {
        private static long FibonacciEvenSum(int n)
        {
            long sum = 0;
            long x = 1;  // Represents the current Fibonacci number being processed
            long y = 2;  // Represents the next Fibonacci number in the sequence
            while (x <= n)
            {
                if (x % 2 == 0)
                    sum += x;
                var z = x + y;
                x = y;
                y = z;
            }

            return sum;
        }
    }
}
