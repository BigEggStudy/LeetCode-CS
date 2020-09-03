using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0498_DiagonalTraverse_Test
    {
        [TestMethod]
        public void FindDiagonalOrder_1()
        {
            var solution = new _0498_DiagonalTraverse();
            var result = solution.FindDiagonalOrder(new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            });
            AssertHelper.AssertArray(new int[] { 1, 2, 4, 7, 5, 3, 6, 8, 9 }, result);
        }
    }
}
