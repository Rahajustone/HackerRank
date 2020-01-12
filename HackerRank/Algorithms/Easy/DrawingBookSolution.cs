namespace HackerRank.Algorithms.Easy
{
    class DrawingBookSolution
    {
        public static int pageCount(int n, int p)
        {

            return n / 2 - p / 2 >= p / 2 ? p / 2 : n / 2 - p / 2;
        }
    }
}