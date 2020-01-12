using System;

namespace HackerRank.Algorithms.Easy
{
    class AppendAndDeleteSolution
    {
        public static string AppendAndDelete(string s, string t, int k)
        {
            string result = "No";
            if (s.Length + t.Length <= k)
                result = "Yes";

            int commonCharacter = 0;
            for (int i = 0; i < Math.Min(s.Length, t.Length); i++)
            {
                if (s[i] != t[i])
                    break;
                commonCharacter++;
            }

            int f = (k - s.Length - t.Length + 2 * commonCharacter);

            if (commonCharacter > 1 && f >= 0 && f % 2 == 0)
                result = "Yes";

            return result;
        }
    }
}