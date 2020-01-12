using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms.Easy
{
    class BetweenTwoSetsSolution
    {
        public static int GetTotalX(List<int> a, List<int> b)
        {
            int maxInA = a.Max();
            int minInB = b.Min();
            int totalNumber = 0;

            var generatedAr = new List<int>();

            for (int i = maxInA; i <= minInB; i++)
            {
                bool status = true;
                foreach (var v in a)
                {
                    if (i % v != 0)
                        status = false;
                }

                if (status)
                    generatedAr.Add(i);
            }

            foreach (var y in generatedAr)
            {
                bool status = true;
                foreach (var v in b)
                {
                    if (v % y != 0)
                        status = false;
                }

                if (status)
                    totalNumber++;
            }

            return totalNumber;
        }
    }
}