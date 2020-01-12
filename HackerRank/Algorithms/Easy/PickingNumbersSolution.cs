using System;
using System.Collections.Generic;

namespace HackerRank.Algorithms.Easy
{
    class PickingNumbersSolution
    {
        public static int PickingNumbers(List<int> a)
        {
            var newList = new int[100];
            int resutMax = 0;

            for (int i = 0; i < a.Count; i++)
            {
                int index = a[i];
                newList[index]++;
            }

            for (int i = 0; i < a.Count; i++)
            {
                resutMax = Math.Max(resutMax, newList[i] + newList[i + 1]);
            }

            return resutMax;
        }
    }
}