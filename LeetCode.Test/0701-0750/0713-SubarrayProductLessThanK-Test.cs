using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0713_SubarrayProductLessThanK_Test
    {
        [TestMethod]
        public void NumSubarrayProductLessThanK_1()
        {
            var solution = new _0713_SubarrayProductLessThanK();
            var result = solution.NumSubarrayProductLessThanK(new int[] { 10, 5, 2, 6 }, 100);
            Assert.AreEqual(8, result);
        }
    }
}
