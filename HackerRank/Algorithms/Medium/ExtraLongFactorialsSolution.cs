using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace HackerRank.Algorithms.Medium
{
    class ExtraLongFactorialsSolution
    {
        public static void ExtraLongFactorials(int n)
        {
            var result = BigInteger.One;
            for (int i = 1; i <= n; i++)
                result *= i;

            Console.WriteLine(result);
        }

    }
}
