using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0231_PowerOfTwo_Test
    {
        [TestMethod]
        public void IsPowerOfTwo_1()
        {
            var solution = new _0231_PowerOfTwo();
            var result = solution.IsPowerOfTwo(1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPowerOfTwo_2()
        {
            var solution = new _0231_PowerOfTwo();
            var result = solution.IsPowerOfTwo(16);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPowerOfTwo_3()
        {
            var solution = new _0231_PowerOfTwo();
            var result = solution.IsPowerOfTwo(218);
            Assert.IsFalse(result);
        }
    }
}
