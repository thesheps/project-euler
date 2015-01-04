using NUnit.Framework;
using ProjectEuler.Maths;

namespace ProjectEuler.Tests.Maths
{
    [TestFixture]
    public class GivenPrimeFactorsList
    {
        [Test]
        public void WhenICalculateExample_PrimeFactorsAreCorrect()
        {
            var results = new PrimeFactorsList(13195);
            var values = new int[] 
            { 
                5, 7, 13, 29
            };

            Assert.That(values, Is.EquivalentTo(results));
        }
    }
}