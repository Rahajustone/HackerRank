using System.Linq;

namespace HackerRank.Algorithms.Easy
{
    class RepeatedStringSolution
    {
        public static long RepeatedString(string s, long n)
        {
            long count = 0;
            count = s.Count(x => x == 'a');
            long a = n / s.Length;
            long b = a * count;

            for (int i = 0; i < n % s.Length; i++)
            {
                if (s[i] == 'a')
                    b++;
            }

            return b;
        }
    }
}