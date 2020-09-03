using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1475_FinalPricesWithASpecialDiscountInAShop_Test
    {
        [TestMethod]
        public void FinalPrices_1()
        {
            var solution = new _1475_FinalPricesWithASpecialDiscountInAShop();
            var result = solution.FinalPrices(new int[] { 8, 4, 6, 2, 3 });
            AssertHelper.AssertArray(new int[] { 4, 2, 4, 2, 3 }, result);
        }

        [TestMethod]
        public void FinalPrices_2()
        {
            var solution = new _1475_FinalPricesWithASpecialDiscountInAShop();
            var result = solution.FinalPrices(new int[] { 1, 2, 3, 4, 5 });
            AssertHelper.AssertArray(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void FinalPrices_3()
        {
            var solution = new _1475_FinalPricesWithASpecialDiscountInAShop();
            var result = solution.FinalPrices(new int[] { 10, 1, 1, 6 });
            AssertHelper.AssertArray(new int[] { 9, 0, 1, 6 }, result);
        }
    }
}
