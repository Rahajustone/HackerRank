using System;
using System.Text;

namespace HackerRank.Algorithms.Easy
{
    class StaircaseSolution
    {
        public static void Staircase(int n)
        {
            int b = n - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = b; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                b--;

                if (b < 0)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
