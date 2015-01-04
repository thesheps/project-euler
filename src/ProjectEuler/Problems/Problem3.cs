using System.Linq;
using ProjectEuler.Maths;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    //The prime factors of 13195 are 5, 7, 13 and 29.
    //
    //What is the largest prime factor of the number 600851475143?
    public class Problem3 : IProblem
    {
        public long Solve()
        {
            var primeFactors = new PrimeFactorsList(600851475143);
            return primeFactors.Max();
        }
    }
}