using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Easy
{
    class SecondArrayDSSolution
    {
        // Complete the hourglassSum function below.
        public static int hourglassSum(int[][] arr)
        {
            int res = 0;
            int max = Int32.MinValue;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr[i].Length - 2; j++)
                {
                    res = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                          + arr[i + 1][j + 1] +
                                arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    if (max < res)
                        max = res;
                }
            }

            return max;
        }
    }
}
