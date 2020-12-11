using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Easy
{
    class ArrayLeftRotationSolution
    {
        public static void ArrayRotateLeft(int []a, int n, int d)
        {
            var listArr = new List<int>();

            for (int i = d; i < n; i++)
                listArr.Add(a[i]);

            for (int j = 0; j < d; j++)
                listArr.Add(a[j]);

            for (int k = 0; k < n; k++)
            {
                Console.Write($"{listArr[k]} ");
            }
        }
    }
}
