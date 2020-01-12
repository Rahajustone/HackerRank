using System;

namespace HackerRank.Algorithms.Easy
{
    class HalloweenSaleSolution
    {
        public static int HowManyGames(int p, int d, int m, int s)
        {
            int numberOfGame = 0;
            int sum = 0;

            while (sum < s)
            {
                sum = sum + p;

                if (p > m)
                {
                    p = p - d;
                }
                
                if (p<m)
                {
                    p = m;
                }

                if (sum <= s)
                {
                    numberOfGame++;
                }

                
            }

            return numberOfGame;
        }
    }
}