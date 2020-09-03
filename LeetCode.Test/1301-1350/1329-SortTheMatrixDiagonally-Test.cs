using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1329_SortTheMatrixDiagonally_Test
    {
        [TestMethod]
        public void DiagonalSort_1()
        {
            var solution = new _1329_SortTheMatrixDiagonally();
            var result = solution.DiagonalSort(new int[][]
            {
                new int[] { 3, 3, 1, 1 },
                new int[] { 2, 2, 1, 2 },
                new int[] { 1, 1, 1, 2 },
            });
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 1, 1, 1, 1 },
                    new int[] { 1, 2, 2, 2 },
                    new int[] { 1, 2, 3, 3 },
                }, result);
        }
    }
}
