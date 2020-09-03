using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0209_MinimumSizeSubarraySum_Test
    {
        [TestMethod]
        public void MinSubArrayLen_1()
        {
            var solution = new _0209_MinimumSizeSubarraySum();
            var result = solution.MinSubArrayLen(7, new int[] { 2, 3, 1, 2, 4, 3 });
            Assert.AreEqual(2, result);
        }
    }
}
