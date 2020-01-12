namespace HackerRank.Algorithms.Easy
{
    class DesignerPdfViewerSolution
    {
        public static int DesignerPdfViewer(int[] h, string word)
        {
            int max = 0;

            for (int i = 0; i < word.Length; i++)
            {
                int normalIndex = (char)word[i] - 97;
                if (h[normalIndex] > max)
                    max = h[normalIndex];
            }

            return max * word.Length;
        }
    }
}