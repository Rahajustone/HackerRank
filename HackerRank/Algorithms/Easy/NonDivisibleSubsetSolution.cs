using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Easy
{
    class NonDivisibleSubsetSolution
    {
        private static int NonDivisibleSubset(int k, List<int> s)
        {
            var maxArrayNonDivisible = new List<int>();

            for (int i = 0; i < s.Count; i++)
            {
                for (int j = (i + 1); j < s.Count; j++)
                {
                    var b = s[i] + s[j];
                    if (b % k != 0 && !maxArrayNonDivisible.Contains(s[i]) && !maxArrayNonDivisible.Contains(s[j]))
                    {
                        maxArrayNonDivisible.Add(s[i]);
                        maxArrayNonDivisible.Add(s[j]);
                    }
                }
            }

            return maxArrayNonDivisible.Count;
        }
    }
}
