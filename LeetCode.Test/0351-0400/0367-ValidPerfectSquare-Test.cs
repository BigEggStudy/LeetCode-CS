using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0367_ValidPerfectSquare_Test
    {
        [TestMethod]
        public void IsPerfectSquare_1()
        {
            var solution = new _0367_ValidPerfectSquare();
            var result = solution.IsPerfectSquare(16);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPerfectSquare_2()
        {
            var solution = new _0367_ValidPerfectSquare();
            var result = solution.IsPerfectSquare(14);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPerfectSquare_3()
        {
            var solution = new _0367_ValidPerfectSquare();
            var result = solution.IsPerfectSquare(808201);
            Assert.IsTrue(result);
        }
    }
}
