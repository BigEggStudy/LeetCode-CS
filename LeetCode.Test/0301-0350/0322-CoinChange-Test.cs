using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0322_CoinChange_Test
    {
        [TestMethod]
        public void CoinChange_1()
        {
            var solution = new _0322_CoinChange();
            var result = solution.CoinChange(new int[] { 1, 2, 5 }, 11);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CoinChange_2()
        {
            var solution = new _0322_CoinChange();
            var result = solution.CoinChange(new int[] { 2 }, 3);
            Assert.AreEqual(-1, result);
        }
    }
}
