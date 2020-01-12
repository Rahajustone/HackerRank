using System;

namespace HackerRank.Algorithms.Easy
{
    class AppleAndOrangeSolution
    {
        static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleCount = 0;
            int orangeCount = 0;

            foreach (var apple in apples)
            {
                int temp = apple + a;
                if (temp >= s && temp <= t)
                    appleCount++;
            }

            foreach (var orange in oranges)
            {
                int temp = orange + b;
                if (temp >= s && temp <= t)
                    orangeCount++;
            }

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }
    }
}