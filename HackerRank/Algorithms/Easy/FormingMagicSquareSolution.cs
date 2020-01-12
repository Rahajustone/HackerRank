using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Easy
{
    class FormingMagicSquareSolution
    {
        private static int FormingMagicSquare(int[][] s)
        {
            int magicSquareSum = 0, tempRow = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tempRow += s[i][j];

                }

                magicSquareSum += Math.Abs(15 - tempRow);
                tempRow = 0;
            }

            return magicSquareSum;
        }
    }
}
