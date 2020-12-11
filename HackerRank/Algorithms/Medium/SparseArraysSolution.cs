using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Medium
{
    class SparseArraysSolution
    {
        public static int[] MatchingStrings(string[] strings, string[] queries)
        {
            var resuts = new List<int>();

            for (int i = 0; i < queries.Length; i++)
            {
                int tempCount = strings.Count(x => x.Equals(queries[i]));
                resuts.Add(tempCount);
            }

            return resuts.ToArray();
        }
    }
}
