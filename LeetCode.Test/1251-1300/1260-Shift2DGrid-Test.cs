using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _1260_Shift2DGrid_Test
    {
        [TestMethod]
        public void ShiftGrid_1()
        {
            var solution = new _1260_Shift2DGrid();
            var result = solution.ShiftGrid(new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            }, 1);
            AssertHelper.AssertList(new List<IList<int>> {
                new int[] { 9, 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6, 7, 8 },
            }, result);
        }

        [TestMethod]
        public void ShiftGrid_2()
        {
            var solution = new _1260_Shift2DGrid();
            var result = solution.ShiftGrid(new int[][] {
                new int[] { 3, 8, 1, 9 },
                new int[] { 19, 7, 2, 5 },
                new int[] { 4, 6, 11, 10 },
                new int[] { 12, 0, 21, 13 },
            }, 4);
            AssertHelper.AssertList(new List<IList<int>> {
                new int[] { 12, 0, 21, 13 },
                new int[] { 3, 8, 1, 9 },
                new int[] { 19, 7, 2, 5 },
                new int[] { 4, 6, 11, 10 },
            }, result);
        }

        [TestMethod]
        public void ShiftGrid_3()
        {
            var solution = new _1260_Shift2DGrid();
            var result = solution.ShiftGrid(new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            }, 9);
            AssertHelper.AssertList(new List<IList<int>> {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            }, result);
        }
    }
}
