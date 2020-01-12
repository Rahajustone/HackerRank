namespace HackerRank.Algorithms.Easy
{
    class ChocolateFeastSolution
    {
        public static int ChocolateFeast(int n, int c, int m)
        {
            int numberOfChocolate = n / c;

            int number =  numberOfChocolate;

            while (number > 0 && number >= m )
            {
                numberOfChocolate += number/m;
                number = number / m + number % m;
            }

            return numberOfChocolate;
        }
    }
}