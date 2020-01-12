using System;
using System.Linq;

namespace HackerRank.Algorithms.Easy
{
    class TheHurdleRaceSolution
    {
        static int HurdleRace(int k, int[] height)
        {
            int max = height.Max();

            return (k - max) > 0 ? 0 : Math.Abs(max - k);
        }
    }
}