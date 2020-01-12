using System;

namespace HackerRank.Algorithms.Easy
{
    class TimeConversionSolution
    {
        private static string TimeConversion(string s)
        {
            string firstPart = s[0] + "" + s[1];
            string middlePart = s.Substring(2, 6);
            string lastPart = s[8] + "" + s[9];
            string result = "";


            if (lastPart.ToLower() == "am")
            {
                if (Int16.Parse(firstPart) == 12)
                {
                    firstPart = "00";
                }

                result = firstPart + "" + middlePart;
            }

            if (lastPart.ToLower() == "pm")
            {
                if (Int16.Parse(firstPart) == 12)
                {
                    result = firstPart + middlePart;
                }
                else
                {

                    result = (Int32.Parse(firstPart) + 12).ToString() + "" + middlePart;
                }
            }

            return result;
        }
    }
}