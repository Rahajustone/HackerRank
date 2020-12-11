using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Easy
{
    class IceCreamParlorSolution
    {
        // Brute Force Solution
        // Walking throug all pairs
        // O(n^2)
        public static int[] IceCreamParlorBrute(int m, int[] arr)
        {
            var arrList = new int[2];

            for (int i = 0; i <= arr.Length-2; i++)
            {
                for (int j = i+1; j <= arr.Length -1; j++)
                {
                    if (arr[i] + arr[j] == m )
                    {
                        arrList[0] = ++i;
                        arrList[1] = ++j;
                        break;
                    }
                }
            }

            return arrList;
        }

        // Binary Search
        public static int[] IceCreamParlor(int m, int[] arr)
        {
            var res = new int[2];
            var sorterArr = new int[arr.Length];
            Array.Copy(arr, sorterArr, arr.Length);
            Array.Sort(sorterArr);

            for (int i = 0; i < arr.Length; i++)
            {
                int temp = m - sorterArr[i];
                var location = Array.BinarySearch(sorterArr, i+1, sorterArr.Length -(i+1), temp);

                if (location >= 0 && sorterArr[location] == temp )
                {
                    res[0] = 1 + IndexOf(arr, sorterArr[i]);
                    res[1] = 1 + IndexOf(arr, temp, res[0] -1 );
                }
            }

            return res;
        }

        public static int IndexOf(int []arr, int targetElement)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == targetElement)
                    return i;
            }

            return -1;
        }

        public static int IndexOf(int []arr, int targetElement, int skipThis)
        {
            int result = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == targetElement && i != skipThis)
                {
                    result = i+1;
                }
            }

            return result;
        }
    }
}
