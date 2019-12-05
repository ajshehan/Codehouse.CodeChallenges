using Codehouse.CodeChallenges.Business.ChallengeZero;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codehouse.CodeChallenges.Business.Tests.ChallengeZero
{
    [TestClass]
    public class GloveMerchantTest
    {
        private readonly GloveMerchant _gloveMerchant;
        public GloveMerchantTest()
        {
            _gloveMerchant = new GloveMerchant();
        }

        [TestMethod]
        public void CountPairs_GivenEmptyArryReturnZero()
        {
            var glovesArry = new int[] { };
            var result = _gloveMerchant.CountPairs(glovesArry);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CountPairs_GivenZeroPairsReturnZero()
        {
            var glovesArry = new [] { 1, 3, 2 };
            var result = _gloveMerchant.CountPairs(glovesArry);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CountPairs_GivenOnePairsReturnOne()
        {
            var glovesArry = new [] { 1, 1, 2 };
            var result = _gloveMerchant.CountPairs(glovesArry);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CountPairs_GivenTwoPairReturnsTwo()
        {
            var glovesArry = new [] { 1, 2, 1, 2, 1, 3, 2 };
            var result = _gloveMerchant.CountPairs(glovesArry);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CountPairs_WhenArryHasSevenItemsAndTwoPair()
        {
            var glovesArry = new [] { 1, 2, 1, 2, 1, 3, 2 };
            var result = _gloveMerchant.CountPairs(glovesArry);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CountPairs_WhenArryHasNineItemsAndThreePair()
        {
            var glovesArry = new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            var result = _gloveMerchant.CountPairs(glovesArry);

            Assert.AreEqual(3, result);
        }
    }
}
