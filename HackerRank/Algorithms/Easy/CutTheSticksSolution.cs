using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms.Easy
{
    class CutTheSticksSolution
    {
        public static int[] CutTheSticks(int[] arr)
        {
            var stepList = new List<int>();
            bool status = false;

            int min = arr.Min();
            int max = Array.LastIndexOf(arr, arr.Max());
            int step = 0;


            while (!status)
            {
                min = arr.Where(x => x != 0).Min();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != 0)
                    {
                        arr[i] = arr[i] - min;

                        step++;
                    }

                    if (arr[max] == 0)
                    {
                        status = true;
                        break;
                    }
                }

                stepList.Add(step);
                step = 0;
            }

            return stepList.ToArray();
        }
    }
}