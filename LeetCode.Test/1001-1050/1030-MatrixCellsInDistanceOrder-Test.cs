using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1030_MatrixCellsInDistanceOrder_Test
    {
        [TestMethod]
        public void AllCellsDistOrder_1()
        {
            var solution = new _1030_MatrixCellsInDistanceOrder();
            var result = solution.AllCellsDistOrder(1, 2, 0, 0);
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 0, 0 },
                    new int[] { 0, 1 },
                }, result);
        }

        [TestMethod]
        public void AllCellsDistOrder_2()
        {
            var solution = new _1030_MatrixCellsInDistanceOrder();
            var result = solution.AllCellsDistOrder(2, 2, 0, 1);
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 0, 1 },
                    new int[] { 0, 0 },
                    new int[] { 1, 1 },
                    new int[] { 1, 0 }
                }, result);
        }

        [TestMethod]
        public void AllCellsDistOrder_3()
        {
            var solution = new _1030_MatrixCellsInDistanceOrder();
            var result = solution.AllCellsDistOrder(2, 3, 1, 2);
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 1, 2 },
                    new int[] { 1, 1 },
                    new int[] { 0, 2 },
                    new int[] { 1, 0 },
                    new int[] { 0, 1 },
                    new int[] { 0, 0 }
                }, result);
        }
    }
}
