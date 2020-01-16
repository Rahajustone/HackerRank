using System;
using System.Collections.Generic;

namespace HackerRank.Algorithms.Easy
{
    public class SuperReducedStringSolution
    {
        public static string SuperReducedString(string s)
        {
            var result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (result.Length > 0)
                    if (result[result.Length - 1] == s[i])
                        result = result.Substring(0, result.Length - 1);
                    else
                        result += s[i];
                else
                    result += s[i];
            }

            return result.Length > 0 ? result : "Empty String";
        }
    }
}
