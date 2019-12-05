using Codehouse.CodeChallenges.Business.ChallengeOne.Animals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codehouse.CodeChallenges.Business.Tests.ChallengeOne
{
    [TestClass]
    public class BirdTest
    {
        private readonly Bird _bird;

        public BirdTest()
        {
            _bird = new Bird();
        }

        [TestMethod]
        public void Bird_WalkTest()
        {
            var succeeded = _bird.Walk();
            Assert.IsTrue(succeeded);
        }

        [TestMethod]
        public void Bird_FlyTest()
        {
            var succeeded = _bird.Fly();
            Assert.IsTrue(succeeded);
        }

        [TestMethod]
        public void Bird_SingTest()
        {
            var succeeded = _bird.MakeSound();
            Assert.IsTrue(succeeded);
        }
    }
}
