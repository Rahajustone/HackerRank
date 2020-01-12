using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms.Easy
{
    class MinimumDistancesSolution
    {
        public static int MinimumDistances(int[] arr)
        {
            int sameNumberMinDistance = -1;
            int tempMinNumber = -1;

            var minListArr = new List<int>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = (i + 1); j < arr.Length; j++)
                {
                    tempMinNumber++;
                    if (arr[i] == arr[j])
                    {
                        tempMinNumber += 1;
                        break;
                    }

                    if (j == arr.Length-1)
                    {
                        tempMinNumber = -1;
                    }
                }

                if (tempMinNumber > -1)
                {
                    sameNumberMinDistance = tempMinNumber;
                    minListArr.Add(tempMinNumber);
                }

                tempMinNumber = -1;
            }
            
            return sameNumberMinDistance == -1 ? -1 : minListArr.Min();
        }


        // Another Way of Solution
        public static int MinimumDistancesNext(int[] arr)
        {
            int sameNumberMinDistance = -1;
            bool flag = true;
            
            for (int i = 0; i < arr.Length; i++)
            {
                var result = Array.IndexOf(arr, arr[i], i + 1);

                if (result > -1)
                {
                    var tempDistance = result - i;

                    if (flag)
                    {
                        sameNumberMinDistance = result - i;
                        flag = false;
                    }

                    if (tempDistance <= sameNumberMinDistance  )
                    {
                        sameNumberMinDistance = tempDistance;
                    }
                }
            }

            return sameNumberMinDistance;
        }
    }
}