using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using HackerRank.Algorithms.Easy;
using HackerRank.Algorithms.Medium;

namespace HackerRank
{ 
    class Program
    {

        static void Main(string[] args)
        {
            // 
            var doubleDimArray = new int[][]
            {
                new[] {1,2,3,4,5,6,7,8,9,0  },
                new [] {0,9,8,7,6,5,4,3,2,1  },
                new [] {0,9,8,7,6,5,4,3,2,1,  },
                new [] {1,1,1,1,1,1,1,1,1,1  },
                new [] {1,1,1,1,1,1,1,1,1,1  },
                new [] {1, 2, 3, 4, 6},
                new [] {1, 2, 3, 4, 6},
                new [] {1, 2, 3, 4, 6},
                new [] {1, 2, 3, 4, 6}

            };

            var doubleDimArraySecond = new int[][]
            {
                new[] { 3, 4},
                new [] { 3, 4},
                new [] { 3, 4}

            };
            var result = 
            GridSearchSolution.GridSearch(doubleDimArray, doubleDimArraySecond);

            Console.WriteLine(result);
            Console.Read();
        }
    }
}
