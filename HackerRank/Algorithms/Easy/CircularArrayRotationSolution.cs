using System;

namespace HackerRank.Algorithms.Easy
{
    class CircularArrayRotationSolution
    {
        public static int[] CircularArrayRotation(int[] arr, int k, int[] queries)
        {
            var result = new int[queries.Length];

            for (int j = 0; j < k; j++)
            {
                RotateLeft(arr);
            }

            for (int i = 0; i < queries.Length; i++)
            {
                result[i] = arr[queries[i]];
            }

            return arr;
        }

        public static void RotateLeft(int[] arr)
        {
            int i, temp = arr[arr.Length - 1];
            for (i = arr.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    arr[0] = temp;
                }
                else
                {
                    arr[i] = arr[i - 1];
                }
            }
        }

        private static int[] CircularArrayRotationSecondWay(int[] arr, int k, int[] queries)
        {
            var newArray = new int[queries.Length];
            LeftShiftArray(arr, k);

            for (int i = 0; i < queries.Length; i++)
            {
                newArray[i] = arr[queries[i]];
            }

            return newArray;
        }

        public static void LeftShiftArray<T>(T[] arr, int shift)
        {
            shift = shift % arr.Length;
            T[] buffer = new T[shift];
            Array.Copy(arr, buffer, shift);
            Array.Copy(arr, shift, arr, 0, arr.Length - shift);
            Array.Copy(buffer, 0, arr, arr.Length - shift, shift);
        }
    }
}