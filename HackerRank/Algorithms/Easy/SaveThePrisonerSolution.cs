namespace HackerRank.Algorithms.Easy
{
    class SaveThePrisonerSolution
    {
        public static int SaveThePrisoner(int n, int m, int s)
        {
            while (m > n)
            {
                m = m - n;
            }

            return m + s - 1;
        }
    }
}