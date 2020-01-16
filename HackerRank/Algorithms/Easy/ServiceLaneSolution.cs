using System;
using System.Collections.Generic;

namespace HackerRank.Algorithms.Easy
{
    public class ServiceLaneSolution
    {
        public static int[] ServiceLane(int n, int[][] cases)
        {
            Console.WriteLine(cases.Length);
            Console.WriteLine(cases[0].Length);


            var serviceList = new List<int>();

            for(int i=0; i< cases.Length; i++)
            {
                for(int j = 0; j< cases[i].Length; j++)
                {
                    Console.WriteLine(cases[i][j]);
                }
            }



            return serviceList.ToArray();
        }
    }
}
