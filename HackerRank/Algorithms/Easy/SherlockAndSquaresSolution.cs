using System;

namespace HackerRank.Algorithms.Easy
{
    class SherlockAndSquaresSolution
    {
        public static int Squares(int a, int b)
        {
            return (int)(Math.Sqrt(b) - Math.Ceiling(Math.Sqrt(a) - 1));

            // Second solution but have time problem
            // Time Problem
            //int count = 0;
            //for (int i = a; i <= b; i++)
            //{
            //    int tempSquare = (int)Math.Sqrt(i);
            //    tempSquare *= tempSquare;
            //    if (tempSquare == a)
            //        count++;
            //}

            //return count;
        }
    }
}