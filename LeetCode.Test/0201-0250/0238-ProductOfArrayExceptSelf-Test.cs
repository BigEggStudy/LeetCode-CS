using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0238_ProductOfArrayExceptSelf_Test
    {
        [TestMethod]
        public void ProductExceptSelfTest_1()
        {
            var solution = new _0238_ProductOfArrayExceptSelf();
            var result = solution.ProductExceptSelf(new int[] { 1, 2, 3, 4 });
            AssertHelper.AssertArray(new int[] { 24, 12, 8, 6 }, result);
        }

        [TestMethod]
        public void ProductExceptSelfTest_2()
        {
            var solution = new _0238_ProductOfArrayExceptSelf();
            var result = solution.ProductExceptSelf(new int[] { 0, 1, 2, 3, 4 });
            AssertHelper.AssertArray(new int[] { 24, 0, 0, 0, 0 }, result);
        }

        [TestMethod]
        public void ProductExceptSelfTest_3()
        {
            var solution = new _0238_ProductOfArrayExceptSelf();
            var result = solution.ProductExceptSelf(new int[] { 1, 2, 3, 4, 0, 0 });
            AssertHelper.AssertArray(new int[] { 0, 0, 0, 0, 0, 0 }, result);
        }
    }
}
