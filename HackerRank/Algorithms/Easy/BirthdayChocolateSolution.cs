using System.Collections.Generic;

namespace HackerRank.Algorithms.Easy
{
    class BirthdayChocolateSolution
    {
        public static int Birthday(List<int> s, int d, int m)
        {
            int waysCount = 0;
            int sum = 0;
            int listLength = 0;
            while (listLength < s.Count)
            {
                if (listLength + m > s.Count)
                {
                    break;
                }
                else
                {
                    int monthLength = 0;
                    sum = 0;

                    while (monthLength < m)
                    {
                        sum += s[listLength + monthLength];
                        monthLength++;
                    }

                    if (sum == d)
                    {
                        waysCount++;
                    }
                }

                listLength++;
            }

            return waysCount;
        }
    }
}