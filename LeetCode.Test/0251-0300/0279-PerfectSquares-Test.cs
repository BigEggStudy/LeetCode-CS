using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0279_PerfectSquares_Test
    {
        [TestMethod]
        public void NumSquaresTest_1()
        {
            var solution = new _0279_PerfectSquares();
            var result = solution.NumSquares(12);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NumSquaresTest_2()
        {
            var solution = new _0279_PerfectSquares();
            var result = solution.NumSquares(13);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void NumSquaresTest_3()
        {
            var solution = new _0279_PerfectSquares();
            var result = solution.NumSquares(4);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void NumSquaresTest_4()
        {
            var solution = new _0279_PerfectSquares();
            var result = solution.NumSquares(15);
            Assert.AreEqual(4, result);
        }
    }
}
