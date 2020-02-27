using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms.Easy
{
    public class ServiceLaneSolution
    {
        public static int[] ServiceLane(int n, int[][] cases)
        {
            var serviceList = new List<int>();

            for(int i=1; i< cases.Length; i++)
            {
                int min = cases[0][cases[i][0]];
                for (int j = cases[i][0]; j < cases[i][1]; j++)
                {
                    if (min > cases[0][j])
                        min = cases[0][j];
                }

                serviceList.Add(min);
            }

            return serviceList.ToArray();
        }
    }
}
