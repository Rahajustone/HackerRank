using System;

namespace HackerRank.Algorithms.Easy
{
    class BeautifulDaysAtTheMoviesSolution
    {
        public static int BeautifulDays(int i, int j, int k)
        {
            int count = 0;
            for (int z = i; z < j; z++)
            {
                int temp = Math.Abs(z - ReverseNumber(z));
                if (temp % k == 0) count++;
            }

            return count;
        }

        private static int ReverseNumber(int n)
        {
            int number = 0;

            while (n != 0)
            {
                number = number * 10 + n % 10;
                n /= 10;
            }

            return number;
        }
    }
}