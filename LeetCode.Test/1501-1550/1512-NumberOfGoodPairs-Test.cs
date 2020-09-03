using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1512_NumberOfGoodPairs_Test
    {
        [TestMethod]
        public void NumIdenticalPairs_1()
        {
            var solution = new _1512_NumberOfGoodPairs();
            var result = solution.NumIdenticalPairs(new int[] { 1, 2, 3, 1, 1, 3 });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void NumIdenticalPairs_2()
        {
            var solution = new _1512_NumberOfGoodPairs();
            var result = solution.NumIdenticalPairs(new int[] { 1, 1, 1, 1 });
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void NumIdenticalPairs_3()
        {
            var solution = new _1512_NumberOfGoodPairs();
            var result = solution.NumIdenticalPairs(new int[] { 1, 2, 3 });
            Assert.AreEqual(0, result);
        }
    }
}
