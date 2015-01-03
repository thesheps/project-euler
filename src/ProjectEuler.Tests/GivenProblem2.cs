using NUnit.Framework;
using ProjectEuler.Problems;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class GivenProblem2 : GivenProblem<Problem2>
    {
        [TestCase]
        public void WhenIGenerateTheFiveTenTerms_TheyAreCorrect()
        {
            var values = new int[] 
            { 
                1, 2, 3, 5, 8
            };

            var results = Problem.GetFibonacci(8);

            Assert.That(values, Is.EquivalentTo(results));
        }

        [TestCase]
        public void WhenIGenerateTheTenTenTerms_TheyAreCorrect()
        {
            var values = new int[] 
            { 
                1, 2, 3, 5, 8, 13, 21, 34, 55, 89
            };

            var results = Problem.GetFibonacci(89);

            Assert.That(values, Is.EquivalentTo(results));
        }
    }
}