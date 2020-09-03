using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0628_MaximumProductOfThreeNumbers_Test
    {
        [TestMethod]
        public void MaximumProduct_1()
        {
            var solution = new _0628_MaximumProductOfThreeNumbers();
            var result = solution.MaximumProduct(new int[] { 1, 2, 3 });
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void MaximumProduct_2()
        {
            var solution = new _0628_MaximumProductOfThreeNumbers();
            var result = solution.MaximumProduct(new int[] { 1, 2, 3, 4 });
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void MaximumProduct_3()
        {
            var solution = new _0628_MaximumProductOfThreeNumbers();
            var result = solution.MaximumProduct(new int[] { 1, 2, -3, -4 });
            Assert.AreEqual(24, result);
        }
    }
}
