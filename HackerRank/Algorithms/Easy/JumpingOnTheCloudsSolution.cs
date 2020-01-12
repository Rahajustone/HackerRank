namespace HackerRank.Algorithms.Easy
{
    class JumpingOnTheCloudsSolution
    {
        public static int JumpingOnClouds(int[] c)
        {
            int pathTakeNumber = 0;

            int index = 0;
            while(index < c.Length-1) { 
                if (c[index] == 0 && index < c.Length - 2 && c[index + 2] == 0 )
                {
                    pathTakeNumber++;
                    index += 2;
                } else if (c[index] == 0 && index < c.Length - 2 &&  c[index + 2] != 0 )
                {
                    pathTakeNumber++;
                    index += 1;
                }
                else if (c[index] == 0 && index <= c.Length - 2 && c[index + 1] == 0)
                {
                    pathTakeNumber++;
                    index += 1;
                }
                else
                {
                    break;
                }

            }

            return pathTakeNumber;
        }
    }
}