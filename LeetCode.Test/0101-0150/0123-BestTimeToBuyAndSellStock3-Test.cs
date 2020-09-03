using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0123_BestTimeToBuyAndSellStock3_Test
    {
        [TestMethod]
        public void MaxProfitTest_1()
        {
            var solution = new _0123_BestTimeToBuyAndSellStock3();
            var result = solution.MaxProfit(new int[] { 3, 3, 5, 0, 0, 3, 1, 4 });
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void MaxProfitTest_2()
        {
            var solution = new _0123_BestTimeToBuyAndSellStock3();
            var result = solution.MaxProfit(new int[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MaxProfitTest_3()
        {
            var solution = new _0123_BestTimeToBuyAndSellStock3();
            var result = solution.MaxProfit(new int[] { 7, 6, 4, 3, 1 });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MaxProfitTest_4()
        {
            var solution = new _0123_BestTimeToBuyAndSellStock3();
            var result = solution.MaxProfit(new int[] { 1, 2, 4, 2, 5, 7, 2, 4, 9, 0 });
            Assert.AreEqual(13, result);
        }
    }
}
