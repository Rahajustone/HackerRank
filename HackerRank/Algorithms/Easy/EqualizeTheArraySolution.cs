using System;
using System.Linq;

namespace HackerRank.Algorithms.Easy
{
    class EqualizeTheArraySolution
    {
        public static int EqualizeArray(int[] arr)
        {
            int sameNumber = 0;
            int tempMaxNumber = 1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = (i + 1); j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        tempMaxNumber++;
                }

                if (sameNumber < tempMaxNumber)
                    sameNumber = tempMaxNumber;

                tempMaxNumber = 1;
            }

            return arr.Length - sameNumber;
        }

        // Solution using Linq
        public static int EqualizeArrayLinq(int[] arr)
        {
            return  arr.Length - arr.GroupBy(x => x).Select(x => x.Count()).Max();
        }
    }
}