using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _052_NQueens2_Test
    {
        [TestMethod]
        public void TotalNQueensTest_NEqualZero()
        {
            var solution = new _052_NQueens2();
            var result = solution.TotalNQueens(0);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TotalNQueensTest_NEqualOne()
        {
            var solution = new _052_NQueens2();
            var result = solution.TotalNQueens(1);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TotalNQueensTest_NEqualTwo()
        {
            var solution = new _052_NQueens2();
            var result = solution.TotalNQueens(2);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TotalNQueensTest_NEqualThree()
        {
            var solution = new _052_NQueens2();
            var result = solution.TotalNQueens(3);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TotalNQueensTest_NEqualFour()
        {
            var solution = new _052_NQueens2();
            var result = solution.TotalNQueens(4);

            Assert.AreEqual(2, result);
        }
    }
}
