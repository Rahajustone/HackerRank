namespace HackerRank.Algorithms.Easy
{
    class UtopianTreeSolution
    {
        public static int UtopianTree(int n)
        {
            int height = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    height *= 2;
                else
                    height++;
            }

            return height;
        }
    }
}