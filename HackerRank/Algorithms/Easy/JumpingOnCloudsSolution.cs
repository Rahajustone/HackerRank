using System.Linq;

namespace HackerRank.Algorithms.Easy
{
    class JumpingOnCloudsSolution
    {
        public static int JumpingOnClouds(int[] c, int k)
        {
            return 100 - (c.Length / k + (c.Where((v, i) => i % k == 0).Sum() * 2));
        }
    }
}