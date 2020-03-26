using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace HackerRank.Algorithms.Medium
{
    public class PairsSolution
    {

        // Using hash Map
        public int PairsWithHashMap(int k, int[] arr)
        {
            int equalDiffElemntsCount = 0;

            var hashmap = new List<bool>();

            for (int i = 0; i < arr.Length; i++)
            {
                hashmap[arr[i]] = true;
            }





        }

        //
        public int Pairs(int k, int[] arr)
        {
            // First we sort array
            Array.Sort(arr);

            var i = 0;
            var j = 1;
            var count = 0;
            while (j < arr.Length)
            {
                var diff = arr[j] - arr[i];

                if (diff == k)
                {
                    count++;
                    j++;
                }
                else if (diff > k)
                {
                    i++;
                }
                else if (diff < k)
                {
                    j++;
                }
            }

            return count;
        }

        // it is not good enough algorithms
        // O(n^2)
        public int PairsSecondSoltuion(int k, int[] arr)
        {
            int equalDiffElemnts = 0;
            for (int i = 0; i < arr.Length; i++)
                for (int j = i+1; j < arr.Length; j++)
                    if (Math.Abs(arr[i] - arr[j]) == k)
                        equalDiffElemnts++;

            return equalDiffElemnts;
        }
    }
}
