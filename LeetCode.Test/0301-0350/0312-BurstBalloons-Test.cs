using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0312_BurstBalloons_Test
    {
        [TestMethod]
        public void MaxCoinsTest()
        {
            var solution = new _0312_BurstBalloons();
            var result = solution.MaxCoins(new int[] { 3, 1, 5, 8 });
            Assert.AreEqual(167, result);
        }
    }
}
