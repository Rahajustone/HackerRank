namespace HackerRank.Algorithms.Easy
{
    class AngryProfessorSolution
    {
        public static string AngryProfessor(int k, int[] a)
        {
            var onTimeStudents = 0;
            foreach (var studentTiming in a)
            {
                if (studentTiming <= 0)
                    onTimeStudents++;

                if (onTimeStudents == k)
                    break;
            }

            return onTimeStudents < k ? "YES" : "NO";
        }
    }
}