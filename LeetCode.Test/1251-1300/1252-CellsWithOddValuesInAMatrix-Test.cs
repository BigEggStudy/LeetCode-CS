using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1252_CellsWithOddValuesInAMatrix_Test
    {
        [TestMethod]
        public void OddCells_1()
        {
            var solution = new _1252_CellsWithOddValuesInAMatrix();
            var result = solution.OddCells(2, 3, new int[][] {
                new int[] { 0, 1 },
                new int[] { 1, 1 },
            });
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void OddCells_2()
        {
            var solution = new _1252_CellsWithOddValuesInAMatrix();
            var result = solution.OddCells(2, 2, new int[][] {
                new int[] { 1, 1 },
                new int[] { 0, 0 },
            });
            Assert.AreEqual(0, result);
        }
    }
}
