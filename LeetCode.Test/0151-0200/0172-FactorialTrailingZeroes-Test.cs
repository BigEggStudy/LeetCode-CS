using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0172_FactorialTrailingZeroes_Test
    {
        [TestMethod]
        public void TrailingZeroes_1()
        {
            var solution = new _0172_FactorialTrailingZeroes();
            var result = solution.TrailingZeroes(3);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TrailingZeroes_2()
        {
            var solution = new _0172_FactorialTrailingZeroes();
            var result = solution.TrailingZeroes(5);
            Assert.AreEqual(1, result);
        }
    }
}
