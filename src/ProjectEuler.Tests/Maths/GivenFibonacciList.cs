using NUnit.Framework;
using ProjectEuler.Maths;

namespace ProjectEuler.Tests.Maths
{
    [TestFixture]
    public class GivenFibonacciList
    {
        [TestCase]
        public void WhenIGenerateTheFiveTenTerms_TheyAreCorrect()
        {
            var values = new int[] 
            { 
                1, 2, 3, 5, 8
            };

            var results = new FibonacciList(8);
            Assert.That(values, Is.EquivalentTo(results));
        }

        [TestCase]
        public void WhenIGenerateTheTenTenTerms_TheyAreCorrect()
        {
            var values = new int[] 
            { 
                1, 2, 3, 5, 8, 13, 21, 34, 55, 89
            };

            var results = new FibonacciList(89);
            Assert.That(values, Is.EquivalentTo(results));
        }
    }
}