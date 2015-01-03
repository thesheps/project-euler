using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public abstract class GivenProblem<TProblem>
        where TProblem : IProblem, new()
    {
        public GivenProblem()
        {
            Problem = new TProblem();
        }

        [Test]
        [MaxTime(60000)]
        public void WhenISolveProblem_ThenResultIsCalculatedInLessThanAMinute()
        {
            Assert.Pass(string.Format("The answer is: {0}", Problem.Solve()));
        }

        protected readonly TProblem Problem;
    }
}