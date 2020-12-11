using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Medium
{
    public class NewYearChaosSolution
    {
        // Complete the minimumBribes function below.
        public static void MinimumBribes(int[] q)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < q.Length; i++)
            {
                dict.Add(q[i], (i + 1));
            }

            int CountMove = 0;
            foreach (var d in dict)
            {
                if (d.Key - d.Value > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                if ((d.Key - d.Value) > 0)
                {
                    CountMove += (d.Key - d.Value);
                }
            }

            Console.WriteLine(CountMove);
        }
    }
}
