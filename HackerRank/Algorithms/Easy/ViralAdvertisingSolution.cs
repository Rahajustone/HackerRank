namespace HackerRank.Algorithms.Easy
{
    class ViralAdvertisingSolution
    {
        public static int ViralAdvertising(int n)
        {
            int sum = 0;
            int b = 5;
            for (int i = 0; i < n; i++)
            {
                sum += b / 2;
                b = (b / 2) * 3;
            }

            return sum;
        }

    }
}