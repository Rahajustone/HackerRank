using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Easy
{
    class StrongPasswordSolution
    {
        public static int MinimumNumber(int n, string password)
        {

            const string numbers = "0123456789";
            const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string specialCharacters = "!@#$%^&*()-+";

            bool flagNumber = false, flagLowerCase = false, flagUpperCase = false, flagSpecialChar = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (numbers.Contains(password[i]))
                    flagNumber = true;

                if (lowerCase.Contains(password[i]))
                    flagLowerCase = true;

                if (upperCase.Contains(password[i]))
                    flagUpperCase = true;

                if (specialCharacters.Contains(password[i]))
                    flagSpecialChar = true;
            }

            int numberNeededChar = 0;

            if (!flagNumber)
                numberNeededChar += 1;

            if (!flagLowerCase)
                numberNeededChar += 1;

            if (!flagUpperCase)
                numberNeededChar += 1;

            if (!flagSpecialChar)
                numberNeededChar += 1;

            int l = password.Length+ numberNeededChar;
            return l >= 6 ? numberNeededChar :  (l >= 6 ? l :  6 - password.Length) ;
        }
    }
}