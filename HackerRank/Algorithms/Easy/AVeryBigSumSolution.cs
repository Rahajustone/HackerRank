using System.Linq;

namespace HackerRank.Algorithms.Easy
{
    class AVeryBigSumSolution
    {
        public static long AVeryBigSum(long[] ar)
        {
            long sum = 0;
            foreach (var num in ar)
            {
                sum += num;
            }

            return sum;
        }

        // Using Linq
        public static long AveryBigSumLinq(long[] ar)
        {
            return ar.Sum();
        }
    }
}