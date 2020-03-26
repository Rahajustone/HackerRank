using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Easy
{

    public class CustomCompare : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x.Length < y.Length) return -1;
            if (x.Length > y.Length) return 1;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < y[i]) return -1;
                if (x[i] > y[i]) return 1;
            }

            return 0;
        }
    }

    class BigSortingSolution
    {
        static string[] BigSorting(string[] unsorted)
        {

            Array.Sort(unsorted, new CustomCompare());
            return unsorted;
            
        }
    }
}
