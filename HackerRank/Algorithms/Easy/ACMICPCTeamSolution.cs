using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Easy
{
    class AcmiCpcTeamSolution
    {
        // OR operation
        public static int[] AcmTeam(string[] topic)
        {
            var listOf = new List<int>();

            for (int i = 0; i < topic.Length - 1; i++)
            {
                for (int j = i + 1; j < topic.Length; j++)
                {
                    var result = OrString(topic[i], topic[j]);
                    listOf.Add(result);
                }
            }

            var maxElement = listOf.Max();
            var maxElementCount = listOf.Count(_ => _ == maxElement);

            // Clear Array
            listOf.Clear();

            listOf.Add(maxElement);
            listOf.Add(maxElementCount);

            return listOf.ToArray();
        }

        private static int OrString(string firstStr, string secondStr)
        {
            int result = 0;

            for (int i = 0; i < firstStr.Length; i++)
                if (!(firstStr[i] == '0' && secondStr[i] == '0'))
                    result++;

            return result;
        }
    }
}
