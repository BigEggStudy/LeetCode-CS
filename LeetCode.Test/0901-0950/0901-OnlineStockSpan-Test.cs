using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0901_OnlineStockSpan_Test
    {
        [TestMethod]
        public void OnlineStockSpanTest_1()
        {
            var solution = new _0901_OnlineStockSpan();
            Assert.AreEqual(1, solution.Next(100));
            Assert.AreEqual(1, solution.Next(80));
            Assert.AreEqual(1, solution.Next(60));
            Assert.AreEqual(2, solution.Next(70));
            Assert.AreEqual(1, solution.Next(60));
            Assert.AreEqual(4, solution.Next(75));
            Assert.AreEqual(6, solution.Next(85));
        }
    }
}
