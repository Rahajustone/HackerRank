using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Medium
{
    class EncryptionSolution
    {
        // Complete the encryption function below.
        public static string Encryption(string s)
        {
            string encString = "";

            // Trim string from white spaces
            s = s.Trim();

            // Get column number 
            int column = (int)Math.Ceiling((decimal)Math.Sqrt(s.Length));

            // Get row number
            int row =  (int)Math.Floor((decimal)Math.Sqrt(s.Length));


            // For loop index go till end
            int i = 0;

            // Go step  by step of string 
            // I mean first row first column then second row first column then third row first column
            // str += arr[0][0] + a[1][0] + a[2][0] .... till end
            // Next Step gone be
            // str += arr[0][1] + arr[1][1] + a[2][1] + a[3][1] till end for string length
            // it gooes till string length by adding column in arr
            int j = 0;

            int c = 0;
            
            while ( i < s.Length)
            {
                encString += s[j];

                j += column;

                if (j >= s.Length)
                {

                    c++;
                    j = c;
                    encString += " ";
                }

                if (c > j)
                {
                    break;
                }

                i++;
            }

            return encString;
        }
    }
}
