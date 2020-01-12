using System;
using System.Collections.Generic;

namespace HackerRank.Algorithms.Easy
{
    class DiagonalDifferenceSolution
    {
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            
            for (var i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                        primaryDiagonal += arr[i][j];

                    if (i == (arr.Count-1-j))
                        secondaryDiagonal += arr[i][j];
                }
            }

            return Math.Abs(primaryDiagonal - secondaryDiagonal);
        }

        // Second
        static int DiagonalDifferenceSecondWay(List<List<int>> arr)
        {
            int leftDiagonal = 0;
            int rightDiagonal = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                        leftDiagonal += arr[i][j];

                    if (i == (arr.Count - 1) - i)
                        rightDiagonal += arr[i][j];
                }
            }

            return Math.Abs(leftDiagonal - rightDiagonal);
        }


        // Third Option
        static int DiagonalDifferenceBad(List<List<int>> arr)
        {
            int sum = 0;
            int sumOne = 0;
            int j;
            for (var i = 0; i < arr.Count; i++)
            {
                for (j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                    {
                        sum += arr[i][j];
                    }
                }
            }

            j = 0;
            for (var i = arr.Count - 1; i >= 0; i--)
            {
                while (j < arr.Count)
                {
                    sumOne += arr[i][j];
                    j++;
                    break;
                }
            }

            int sumResult = sum - sumOne;

            if (sumResult < 0)
            {
                return (-1) * sumResult;
            }

            return sumResult;
        }

    }
}