using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0643_MaximumAverageSubarrayI_Test
    {
        [TestMethod]
        public void FindMaxAverage_1()
        {
            var solution = new _0643_MaximumAverageSubarrayI();
            var result = solution.FindMaxAverage(new int[] { 1, 12, -5, -6, 50, 3 }, 4);
            Assert.AreEqual(12.75, result);
        }

        [TestMethod]
        public void FindMaxAverage_2()
        {
            var solution = new _0643_MaximumAverageSubarrayI();
            var result = solution.FindMaxAverage(new int[] { 1, 12, -5, -6, 50, 3 }, 2);
            Assert.AreEqual(26.5, result);
        }
    }
}
