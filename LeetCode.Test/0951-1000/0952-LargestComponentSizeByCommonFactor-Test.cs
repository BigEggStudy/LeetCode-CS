using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0952_LargestComponentSizeByCommonFactor_Test
    {
        [TestMethod]
        public void LargestComponentSize_1()
        {
            var solution = new _0952_LargestComponentSizeByCommonFactor();
            var result = solution.LargestComponentSize(new int[] { 4, 6, 15, 35 });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void LargestComponentSize_2()
        {
            var solution = new _0952_LargestComponentSizeByCommonFactor();
            var result = solution.LargestComponentSize(new int[] { 20, 50, 9, 63 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void LargestComponentSize_3()
        {
            var solution = new _0952_LargestComponentSizeByCommonFactor();
            var result = solution.LargestComponentSize(new int[] { 2, 3, 6, 7, 4, 12, 21, 39 });
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void LargestComponentSize_4()
        {
            var solution = new _0952_LargestComponentSizeByCommonFactor();
            var result = solution.LargestComponentSize(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 });
            Assert.AreEqual(14, result);
        }
    }
}
