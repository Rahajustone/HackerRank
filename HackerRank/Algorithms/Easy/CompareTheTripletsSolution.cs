using System.Collections.Generic;

namespace HackerRank.Algorithms.Easy
{
    class CompareTheTripletsSolution
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int pointFirstArray = 0;
            int pointSecondArray = 0;
            var result = new List<int>();

            if (a[0] > b[0])
                pointFirstArray++;
            else
                pointSecondArray++;

            if (a[1] > b[1])
                pointFirstArray++;
            else
                pointSecondArray++;

            if (a[2] > b[2])
                pointFirstArray++;
            else
                pointSecondArray++;

            result.Add(pointFirstArray);
            result.Add(pointSecondArray);

            return result;
        }

        // Option Solution
        public static List<int> CompareInfinity(List<int> a, List<int> b)
        {
            int pointFirstArray = 0;
            int pointSecondArray = 0;
            var result = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    pointFirstArray++;
                }

                if (a[i] < b[i])
                {
                    pointSecondArray++;
                }
            }

            result.Add(pointFirstArray);
            result.Add(pointSecondArray);

            return result;
        }
    }
}