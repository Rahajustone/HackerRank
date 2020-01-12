namespace HackerRank.Algorithms.Easy
{
    class CountingValleysSolution
    {
        public static int CountingValleys(int n, string s)
        {
            int currentLevel = 0;
            int v = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                    currentLevel++;
                if (s[i] == 'D')
                    currentLevel--;

                if (currentLevel == 0 && s[i] == 'U')
                    ++v;
            }

            return v;
        }
    }
}