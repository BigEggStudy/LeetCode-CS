using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0532_KDiffPairsInAnArray_Test
    {
        [TestMethod]
        public void FindPairs_1()
        {
            var solution = new _0532_KDiffPairsInAnArray();
            var result = solution.FindPairs(new int[] { 3, 1, 4, 1, 5 }, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindPairs_2()
        {
            var solution = new _0532_KDiffPairsInAnArray();
            var result = solution.FindPairs(new int[] { 1, 2, 3, 4, 5 }, 1);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void FindPairs_3()
        {
            var solution = new _0532_KDiffPairsInAnArray();
            var result = solution.FindPairs(new int[] { 1, 3, 1, 5, 4 }, 0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindPairs_4()
        {
            var solution = new _0532_KDiffPairsInAnArray();
            var result = solution.FindPairs(new int[] { 1, 2, 3, 4, 5 }, -1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FindPairs_5()
        {
            var solution = new _0532_KDiffPairsInAnArray();
            var result = solution.FindPairs(new int[] { 1, 1, 1, 1, 1, 1 }, 0);
            Assert.AreEqual(1, result);
        }
    }
}
