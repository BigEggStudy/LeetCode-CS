using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0840_MagicSquaresInGrid_Test
    {
        [TestMethod]
        public void NumMagicSquaresInside_1()
        {
            var solution = new _0840_MagicSquaresInGrid();
            var result = solution.NumMagicSquaresInside(new int[][] {
                new int[] { 4, 3, 8, 4 },
                new int[] { 9, 5, 1, 9 },
                new int[] { 2, 7, 6, 2 },
            });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void NumMagicSquaresInside_2()
        {
            var solution = new _0840_MagicSquaresInGrid();
            var result = solution.NumMagicSquaresInside(new int[][] {
                new int[] { 1, 8, 6 },
                new int[] { 10, 5, 0 },
                new int[] { 4, 2, 9 },
            });
            Assert.AreEqual(0, result);
        }
    }
}
