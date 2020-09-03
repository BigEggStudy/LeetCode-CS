using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0309_BestTimeToBuyAndSellStockWithCooldown_Test
    {
        [TestMethod]
        public void MaxProfit_1()
        {
            var solution = new _0309_BestTimeToBuyAndSellStockWithCooldown();
            var result = solution.MaxProfit(new int[] { 1, 2, 3, 0, 2 });
            Assert.AreEqual(3, result);
        }
    }
}
