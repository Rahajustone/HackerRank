using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Easy
{
    class PlusMinusSolution
    {
        static void PlusMinus(int[] arr)
        {
            int positiveNumber = 0;
            int negativeNumber = 0;
            int zeroNumber = 0;
            int arrLength = arr.Length;

            foreach (var number in arr)
            {
                if (number > 0)
                {
                    positiveNumber++;
                }
                else if (number < 0)
                {
                    negativeNumber++;
                }
                else
                {
                    zeroNumber++;
                }
            }

            Console.WriteLine((float)positiveNumber / arrLength);
            Console.WriteLine((float)negativeNumber / arrLength);
            Console.WriteLine((float)zeroNumber / arrLength);
        }
    }
}
