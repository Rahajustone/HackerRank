using System.Collections.Generic;

namespace HackerRank.Algorithms.Easy
{
    class BreakingTheRecordsSolution
    {
        public static List<int> BreakingRecords(int[] scores)
        {
            var listInt = new List<int>();

            int min = scores[0];
            int max = scores[0];
            int minScoresCount = 0;
            int maxScoresCount = 0;

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < min)
                {
                    minScoresCount++;
                    min = scores[i];
                }

                if (scores[i] > max)
                {
                    maxScoresCount++;
                    max = scores[i];
                }
            }

            listInt.Add(maxScoresCount);
            listInt.Add(minScoresCount);

            return listInt;
        }
    }
}