using System;
using System.Collections.Generic;

namespace HackerRank.Algorithms.Easy
{
    class SequenceEquationSolution
    {
        static int[] PermutationEquation(int[] p)
        {
            var newArray = new List<int>();

            int step = 1;

            while (step <= p.Length)
            {
                var first = Array.IndexOf(p, step);
                first++;

                var second = Array.IndexOf(p, first);
                second++;
                newArray.Add(second);

                step++;
            }

            return newArray.ToArray();
        }
    }
}