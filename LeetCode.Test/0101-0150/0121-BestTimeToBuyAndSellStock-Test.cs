using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0121_BestTimeToBuyAndSellStock_Test
    {
        [TestMethod]
        public void MaxProfitTest_1()
        {
            var solution = new _0121_BestTimeToBuyAndSellStock();
            var result = solution.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void MaxProfitTest_2()
        {
            var solution = new _0121_BestTimeToBuyAndSellStock();
            var result = solution.MaxProfit(new int[] { 7, 6, 4, 3, 1 });
            Assert.AreEqual(0, result);
        }
    }
}
