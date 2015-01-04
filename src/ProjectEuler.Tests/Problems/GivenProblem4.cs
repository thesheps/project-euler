using NUnit.Framework;
using ProjectEuler.Problems;

namespace ProjectEuler.Tests.Problems
{
    public class GivenProblem4 : GivenProblem<Problem4>
    {
        [Test]
        public void WhenICalculateExample_ThenResultIsPalindromic()
        {
            var result = Problem.IsPalindrome(91 * 99);
            Assert.IsTrue(result);
        }
    }
}