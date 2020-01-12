using System;
using System.Linq;

namespace HackerRank.Algorithms.Easy
{
    class MiniMaxSumSolution
    {
        static void MiniMaxSum(int[] arr)
        {
            long sumAll = arr.Sum();
            long minValue = arr.Min();
            long maxValue = arr.Max();

            Console.Write($"{(long)sumAll - maxValue} {(long)sumAll - minValue}");
        }
    }
}