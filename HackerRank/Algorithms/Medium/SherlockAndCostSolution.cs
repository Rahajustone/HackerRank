using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Medium
{
    class SherlockAndCostSolution
    {
        public static int Cost(int[] B)
        {
            var ifOnePicked = 0;
            var ifValuePicked = 0;
            for (var index = 1; index < B.Length; index++)
            {
                var fromOneToValue = B[index] - 1;
                var fromValueToOne = B[index - 1] - 1;
                var fromPreviousValueToValue = Math.Abs(B[index] - B[index - 1]);

                var nextIfOnePicked = Math.Max(ifOnePicked, ifValuePicked + fromValueToOne);
                var nextIfValuePicked = Math.Max(ifValuePicked + fromPreviousValueToValue, ifOnePicked + fromOneToValue);

                ifOnePicked = nextIfOnePicked;
                ifValuePicked = nextIfValuePicked;
            }

            return Math.Max(ifOnePicked, ifValuePicked);
        }
    }
}
