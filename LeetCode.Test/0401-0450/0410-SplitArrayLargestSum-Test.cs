using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0410_SplitArrayLargestSum_Test
    {
        [TestMethod]
        public void SplitArrayTest()
        {
            var solution = new _0410_SplitArrayLargestSum();
            Assert.AreEqual(18, solution.SplitArray(new int[] {7, 2, 5, 10, 8}, 2));
        }

        [TestMethod]
        public void SplitArrayTest_EmptyArray()
        {
            var solution = new _0410_SplitArrayLargestSum();
            Assert.AreEqual(0, solution.SplitArray(new int[] {}, 2));
        }

        [TestMethod]
        public void SplitArrayTest_OneItem()
        {
            var solution = new _0410_SplitArrayLargestSum();
            Assert.AreEqual(2, solution.SplitArray(new int[] {2}, 1));
        }
    }
}
