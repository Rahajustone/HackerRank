using System.Collections.Generic;

namespace HackerRank.Algorithms.Easy
{
    class GradingStudentsSolution
    {
        public static List<int> GradingStudents(List<int> grades)
        {
            var generatedGrade = new List<int>();

            foreach (var grade in grades)
            {
                if (grade > 38)
                {
                    var reminder = grade % 5;
                    if (reminder >= 3)
                    {
                        if (reminder == 4)
                        {
                            generatedGrade.Add(grade + 1);
                        }

                        if (reminder == 3)
                        {
                            generatedGrade.Add(grade + 2);
                        }
                    }
                    else
                    {
                        generatedGrade.Add(grade);
                    }
                }
                else
                {
                    generatedGrade.Add(grade);
                }
            }

            return generatedGrade;
        }
    }
}