using System.Linq;

namespace HackerRank.Algorithms.Easy
{
    class BeautifulTripletsSolution
    {
        public static int BeautifulTriplets(int d, int[] arr)
        {
            int tripletSum = 0;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                if ( arr.Contains(arr[i] + d ) && arr.Contains(arr[i] + d*2))
                    tripletSum++;
            }

            return tripletSum;
        }

        // O(n^3) == (i*j*k)
        public static int BeautifulTripletsAnotherWay(int d, int[] arr)
        {
            int tripletSum = 0;

            for (int i = 0; i < arr.Length-2; i++)
            {
                for (int j = (i+1); j < arr.Length-1; j++)
                {
                    if (arr[j] - arr[i] == d)
                    {
                        for (int k = (j+1); k < arr.Length; k++)
                        {
                            if (arr[k] - arr[j] == d)
                            {
                                tripletSum++;
                            }
                        }
                    }
                }
            }
            
            return tripletSum;
        }
    }
}