using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0518_CoinChange2_Test
    {
        [TestMethod]
        public void Change_1()
        {
            var solution = new _0518_CoinChange2();
            var result = solution.Change(5, new int[] { 1, 2, 5 });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Change_2()
        {
            var solution = new _0518_CoinChange2();
            var result = solution.Change(3, new int[] { 2 });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Change_3()
        {
            var solution = new _0518_CoinChange2();
            var result = solution.Change(10, new int[] { 10 });
            Assert.AreEqual(1, result);
        }
    }
}
