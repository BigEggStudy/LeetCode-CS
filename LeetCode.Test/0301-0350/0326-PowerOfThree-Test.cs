using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0326_PowerOfThree_Test
    {
        [TestMethod]
        public void IsPowerOfThree_1()
        {
            var solution = new _0326_PowerOfThree();
            var result = solution.IsPowerOfThree(27);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPowerOfThree_2()
        {
            var solution = new _0326_PowerOfThree();
            var result = solution.IsPowerOfThree(0);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPowerOfThree_3()
        {
            var solution = new _0326_PowerOfThree();
            var result = solution.IsPowerOfThree(9);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPowerOfThree_4()
        {
            var solution = new _0326_PowerOfThree();
            var result = solution.IsPowerOfThree(45);
            Assert.IsFalse(result);
        }
    }
}
