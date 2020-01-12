namespace HackerRank.Algorithms.Easy
{
    class FindDigitsSolution
    {
        public static int FindDigits(int n)
        {
            int count = 0;
            int number = n;

            while (number != 0)
            {
                int reminder = number % 10;
                if (reminder != 0 && n % reminder == 0)
                    count++;

                number /= 10;
            }

            return count;
        }
    }
}