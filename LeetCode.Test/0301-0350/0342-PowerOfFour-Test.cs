using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0342_PowerOfFour_Test
    {
        [TestMethod]
        public void IsPowerOfFour_1()
        {
            var solution = new _0342_PowerOfFour();
            var result = solution.IsPowerOfFour(16);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPowerOfFour_2()
        {
            var solution = new _0342_PowerOfFour();
            var result = solution.IsPowerOfFour(5);
            Assert.IsFalse(result);
        }
    }
}
