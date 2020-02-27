using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Medium
{
    public class GridSearchSolution
    {
        // Complete the gridSearch function below.
        //public static string GridSearch(string[] G, string[] P)
        //{
        //    for (int i = 0; i < UPPER; i++)
        //    {
                
        //    }


        //    return "YES";
        //}


        // Grid and Pattern
        public static bool GridSearch(int[][] G, int[][]P)
        {

            bool flag = false;

            int k = 0, l = 0;

            int getRow = P.Length;
            int getCol = P[0].Length;


            for (int i = 0; i < G.Length; i++)
            {
                for (int j = 0; j < G[i].Length; j++)
                {

                    if (G[i][j] == P[k][l])
                    {
                        if (IsEqualTwoArray(G, P, i, j))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        // Two same size array n*m == n*m
        public static bool IsEqualTwoArray(int[][] G, int[][] P, int i, int j)
        {
            int temp = j;
        
            for (int k = 0; k < P.Length; k++)
            {
                j = temp;
                for (int l = 0; l < P[0].Length; l++)
                {
                    if (P[k][l] != G[i][j])
                    {
                        return false;
                    }

                    j++;
                }

                i++;
            }

            return true;
        }

    }
}
