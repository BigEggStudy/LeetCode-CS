using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0441_ArrangingCoins_Test
    {
        [TestMethod]
        public void ArrangeCoins_1()
        {
            var solution = new _0441_ArrangingCoins();
            var result = solution.ArrangeCoins(5);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ArrangeCoins_2()
        {
            var solution = new _0441_ArrangingCoins();
            var result = solution.ArrangeCoins(8);
            Assert.AreEqual(3, result);
        }
    }
}
