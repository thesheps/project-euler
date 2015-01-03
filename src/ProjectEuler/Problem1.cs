using System;
using System.Linq;

namespace ProjectEuler.Problems
{
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, 
    // we get 3, 5, 6 and 9. The sum of these multiples is 23.
    // Find the sum of all the multiples of 3 or 5 below 1000.
    public class Problem1 : IProblem
    {
        public int Solve(int maxNumber)
        {
            var result = Enumerable
                .Range(0, maxNumber)
                .Where(i => i % 3 == 0 | i % 5 == 0)
                .Sum();

            return result;
        }

        public int Solve()
        {
            return Solve(1000);
        }
    }
}
