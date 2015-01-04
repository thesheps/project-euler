using System;
using System.Collections.Generic;

namespace ProjectEuler.Maths
{
    public class PrimeFactorsList : List<long>
    {
        public PrimeFactorsList(long maxValue)
        {
            for (long l = 1; l <= Math.Sqrt(maxValue); l += 2)
            {
                if (maxValue % l == 0 && IsPrimeNumber(l))
                {
                    Add(l);
                }
            }
        }

        private bool IsPrimeNumber(long number)
        {
            var divisors = 0;

            if (number == 1) return false;
            if (number % 2 == 0) return false;

            for (long l = 1; l <= number / 2; l += 2)
            {
                if (number % l == 0) divisors++;
                if (divisors >= 2) return false;
            }

            return true;
        }
    }
}