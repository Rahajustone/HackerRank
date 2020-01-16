using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using HackerRank.Algorithms.Easy;

namespace HackerRank
{ 
    class Program
    {

        static void Main(string[] args)
        {
            // Call the Class which you want
            //ServiceLaneSolution.ServiceLane(8, new int[][]
            //{
            //    new int[] { 2, 3, 1, 2, 3, 2, 3, 3 },
            //    new int[] {0, 3},
            //    new int[] {4, 6},
            //    new int[] {6, 7},
            //    new int[] {3, 5},
            //    new int[] {0, 7}

            //});

            var res = SuperReducedStringSolution.SuperReducedString("aaabbccdddd");
            Console.WriteLine(res);
            Console.Read();
        }
    }
}
