using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Medium
{
    class FormingAMagicSquare
    {
        #pragma warning disable CA1814 // Prefer jagged arrays over multidimensional
        private static readonly int[,] _magicSquare = new int[,] {
            { 8, 1, 6, 3, 5, 7, 4, 9, 2 },
            { 6, 1, 8, 7, 5, 3, 2, 9, 4 },
            { 4, 9, 2, 3, 5, 7, 8, 1, 6 },
            { 2, 9, 4, 7, 5, 3, 6, 1, 8 },
            { 8, 3, 4, 1, 5, 9, 6, 7, 2 },
            { 4, 3, 8, 9, 5, 1, 2, 7, 6 },
            { 6, 7, 2, 1, 5, 9, 8, 3, 4 },
            { 2, 7, 6, 9, 5, 1, 4, 3, 8 }
        };
        #pragma warning restore CA1814 // Prefer jagged arrays over multidimensional

        public static int formingMagicSquare(int[][] s)
        {
            int minCost = Int32.MaxValue;
            int result = 0;
                        
            for(int i=0; i<_magicSquare.GetLength(0); i++)
            {
                for (int j = 0; j < _magicSquare.GetLength(1); j++)
                {
                    result += Math.Abs(s[j / 3][j % 3] - _magicSquare[i,j]);
                    minCost = minCost < result ? minCost : result;
                }                
            }

            return minCost;
        }
    }
}
