using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Easy
{
    class TaumAndBdaySolution
    {
        public static long TaumBday(int b, int w, int bc, int wc, int z)
        {
            long minBlackPrice = Math.Min(bc, wc + z);
            long minWhitePrice = Math.Min(wc, bc + z);

            return b * minBlackPrice + w * minWhitePrice;
        }
    }
}
