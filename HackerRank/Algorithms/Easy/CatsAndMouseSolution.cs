namespace HackerRank.Algorithms.Easy
{
    class CatsAndMouseSolution
    {
        public static string CatAndMouse(int x, int y, int z)
        {
            string answer;

            int catA = (z - x) > 0 ? (z - x) : (-1) * (z - x);
            int catB = (z - y) > 0 ? (z - y) : (-1) * (z - y);

            if (catA < catB)
            {
                answer = "Cat A";
            }
            else if (catA > catB)
            {
                answer = "Cat B";
            }
            else
            {
                answer = "Mouse C";
            }

            return answer;
        }
    }
}