namespace HackerRank.Algorithms.Easy
{
    class ElectronicsShopSolution
    {
        public static int GetMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int maxNumber = 0;

            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    int tempAdd = keyboards[i] + drives[j];
                    if (tempAdd <= b)
                    {
                        if (tempAdd > maxNumber)
                        {
                            maxNumber = tempAdd;
                        }
                    }
                }
            }

            return maxNumber > 0 ? maxNumber : -1;
        }
    }
}