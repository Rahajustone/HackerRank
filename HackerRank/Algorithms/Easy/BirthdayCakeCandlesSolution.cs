using System.Linq;

namespace HackerRank.Algorithms.Easy
{
    class BirthdayCakeCandlesSolution
    {
        public static int BirthdayCakeCandles(int[] ar)
        {
            return ar.Count(x => x == ar.Max());
        }
    }
}