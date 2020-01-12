using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms.Easy
{
    class ModifiedKaprekarNumbersSolution
    {
        public static void KaprekarNumbers(int p, int q)
        {
            int step = 0;

            for (int i = p; i <= q; i++)
            {
                if (IsKaprekarNumbers(i))
                {
                    if (step == 0)
                        Console.Write(i);
                    else
                        Console.Write($" {i}");

                    step++;
                }
            }

            if (step==0)
                Console.WriteLine("INVALID RANGE");
        }

        private static bool IsKaprekarNumbers(int number)
        {
            if (number == 1)
                return true;

            if (number > 1 && number < 4)
                return false;

            long squaredNumber =   (long)number * (long)number;

            var numberToStr = number.ToString();

            var squareNumberToStr = squaredNumber.ToString();

            int n = squareNumberToStr.Length;

            var result = Math.Floor((double) n / 2 + 0.5);

            var rightPart =
                squareNumberToStr.Substring(squareNumberToStr.Length / 2,  (int)(result));

            var leftPart = squareNumberToStr.Substring(0, squareNumberToStr.Length/2);

            return  Convert.ToInt32(rightPart) + Convert.ToInt32(leftPart) == number;
        }


        // Another way I face with On Net
        /// <summary>
        /// Another Solution
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        static void kaprekarNumbers(int p, int q)
        {
            var result = new List<int>();

            for (var i = p; i < q + 1; i++)
            {
                if (IsKaprekar(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(!result.Any() ? "INVALID RANGE" : string.Join(" ", result));
        }
        
        private static bool IsKaprekar(int i)
        {
            // how many digits?
            int magnitude = (int)Math.Floor(Math.Log10(i) + 1);

            double square = Math.Pow(i, 2);

            // get right digits
            double r = square % Math.Pow(10, magnitude);

            // get left digits
            double l = square / Math.Pow(10, magnitude);

            return (int)(l + r) == i;
        }
    }
}