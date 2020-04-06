using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Medium
{
    class BiggerIsGreaterSolution
    {
        // TODO
        // Complete the biggerIsGreater function below.
        public static string BiggerIsGreater(string w)
        {

            //var strCharArray = w.ToCharArray();
            //int length = w.Length;
            //int endIndex = 0;

            //// Start from End
            //// Find the right Most smaller character
            //for (endIndex = length-1; endIndex > 0; endIndex--)
            //{
            //    if (strCharArray[endIndex] > strCharArray[endIndex-1] )
            //    {
            //        break;
            //    }
            //}

            //if (endIndex == 0)
            //{
            //    return "No Answer";
            //} else
            //{
            //    int firstSmallChar = strCharArray[endIndex - 1];
            //    int nextSmallChar = endIndex;

            //    // step-2) Find the smallest character on right side of (endIndex - 1)'th
            //    // character that is greater than charArray[endIndex - 1]
            //    for (int startIndex = endIndex + 1; startIndex < length; startIndex++)
            //    {
            //        if (strCharArray[startIndex] > firstSmallChar && strCharArray[startIndex] < strCharArray[nextSmallChar])
            //        {
            //            nextSmallChar = startIndex;
            //        }
            //    }

            //    // step-3) Swap the above found next smallest character with charArray[endIndex - 1]
            //    swap(strCharArray, endIndex - 1, nextSmallChar);

            //    // step-4) Sort the charArray after (endIndex - 1)in ascending order
            //    Arrays.Sort(strCharArray, endIndex, n);
            //}


            return "sasa";
        }

        //static void swap(char charArray[], int i, int j)
        //{
        //    char temp = charArray[i];
        //    charArray[i] = charArray[j];
        //    charArray[j] = temp;
        //}
    }
}
