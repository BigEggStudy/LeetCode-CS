using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0560_SubarraySumEqualsK_Test
    {
        [TestMethod]
        public void SubarraySumTest_1()
        {
            var solution = new _0560_SubarraySumEqualsK();
            var result = solution.SubarraySum(new int[] { 1, 1, 1 }, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SubarraySumTest_2()
        {
            var solution = new _0560_SubarraySumEqualsK();
            var result = solution.SubarraySum(new int[] { 1, 1, 1, -1, 1 }, 3);
            Assert.AreEqual(2, result);
        }
    }
}
