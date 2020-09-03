using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0122_BestTimeToBuyAndSellStock2_Test
    {
        [TestMethod]
        public void MaxProfitTest_1()
        {
            var solution = new _0122_BestTimeToBuyAndSellStock2();
            var result = solution.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void MaxProfitTest_2()
        {
            var solution = new _0122_BestTimeToBuyAndSellStock2();
            var result = solution.MaxProfit(new int[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MaxProfitTest_3()
        {
            var solution = new _0122_BestTimeToBuyAndSellStock2();
            var result = solution.MaxProfit(new int[] { 7, 6, 4, 3, 1 });
            Assert.AreEqual(0, result);
        }
    }
}
