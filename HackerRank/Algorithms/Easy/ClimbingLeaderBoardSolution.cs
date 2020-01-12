using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Easy
{
    class ClimbingLeaderBoardSolution
    {
        public static int[] ClimbingLeaderBoard(int[] scores, int[] alice)
        {
            var result = new List<int>();
            var resultList = new List<int>();
            resultList.AddRange(scores);

            foreach (var b in alice)
            {
                resultList.Add(b);
                resultList = resultList.OrderByDescending(x => x).Distinct().ToList();
                result.Add(resultList.IndexOf(b) + 1);
                resultList.Remove(b);
            }

            return result.ToArray();
        }

    }
}
