using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0327_CountOfRangeSum_Test
    {
        [TestMethod]
        public void CountRangeSumTest()
        {
            var solution = new _0327_CountOfRangeSum();
            var result = solution.CountRangeSum(new int[] { -2, 5, -1 }, -2, 2);
            Assert.AreEqual(3, result);
        }
    }
}
