using NUnit.Framework;
using ProjectEuler.Problems;

namespace ProjectEuler.Tests.Problems
{
    public class GivenProblem1 : GivenProblem<Problem1>
    {
        [TestCase(10, 23)]
        [TestCase(15, 45)]
        public void WhenICalculateExample_ThenValueIsCorrect(int input, int expectedValue)
        {
            var result = Problem.Solve(input);
            Assert.AreEqual(expectedValue, result);
        }
    }
}
