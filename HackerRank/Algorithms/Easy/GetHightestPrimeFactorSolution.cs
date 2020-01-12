using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Easy
{
    class GetHightestPrimeFactorSolution
    {
        public static long GetHightestPrimeFactor(long n)
        {
            long lastPrimeFactor = 0;

            for (long i = 2; i < n; i++)
            {
                if (IsPrime(i) && n % i == 0)
                {
                    lastPrimeFactor = i;
                    break;
                }
            }

            return lastPrimeFactor;
        }

        private static bool IsPrime(long n)
        {
            if (n == 2) return true;
            if ((n > 2 && n % 2 == 0) || n == 1) return false;

            for (long i = (long)Math.Floor(Math.Sqrt(n)); i >= 2; i--)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
