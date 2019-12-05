using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codehouse.CodeChallenges.Business.Tests
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void AddIntegers_RerunsResultCorrectlyForAnArrayWithMixedTypes()
        {
            object[] array =
            {
                "abc",
                null,
                2.5,
                2,
                3.08f,
                -8,
                true,
                new[] {1, 2, 3}
            };

            var sample = new Sample();
            var result = sample.AddIntegers(array);
            Assert.AreEqual(-6, result);
        }

        [TestMethod]
        public void AddIntegers_RerunsNullForAnEmptyArray()
        {
            object[] array = { };

            var sample = new Sample();
            var result = sample.AddIntegers(array);
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void AddIntegers_RerunsNullForANullArray()
        {
            var sample = new Sample();
            var result = sample.AddIntegers(null);
            Assert.AreEqual(null, result);
        }
    }
}
