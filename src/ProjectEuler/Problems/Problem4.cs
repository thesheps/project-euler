using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    // A palindromic number reads the same both ways. 
    // The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    //
    // Find the largest palindrome made from the product of two 3-digit numbers.
    public class Problem4 : IProblem
    {
        public long Solve()
        {
            var values = new List<int>();
            var value = 0;

            for (int x = 999; x >= 1; x--)
            {
                for (int y = x; y >= 1; y--)
                {
                    value = x * y;

                    if (!values.Contains(value))
                    {
                        if (IsPalindrome(value))
                        {
                            values.Add(value);
                        }
                    }
                }                
            }

            return values.Max();
        }

        public bool IsPalindrome(int number)
        {
            var str = number.ToString();

            if (str.Length % 2 == 1) return false;

            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - (i+1)]) return false;
            }

            return true;
        }
    }
}