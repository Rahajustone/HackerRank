using System.Linq;

namespace HackerRank.Algorithms.Easy
{
    class SimpleArraySumSolution
    {
        public static int SimpleArraySum(int[] ar)
        {
            var sum = 0;
            foreach (var num in ar)
            {
                sum = sum + num;
            }

            return sum;
        }

        // Solution using LINQ
        public static int SimpleArraySumLing(int[] ar)
        {
            return ar.Sum();
        }
    }
}