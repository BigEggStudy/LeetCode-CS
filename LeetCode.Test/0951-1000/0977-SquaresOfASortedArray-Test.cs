using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0977_SquaresOfASortedArray_Test
    {
        [TestMethod]
        public void SortedSquares_1()
        {
            var solution = new _0977_SquaresOfASortedArray();
            var result = solution.SortedSquares(new int[] { -4, -1, 0, 3, 10 });
            AssertHelper.AssertArray(new int[] { 0, 1, 9, 16, 100 }, result);
        }

        [TestMethod]
        public void SortedSquares_2()
        {
            var solution = new _0977_SquaresOfASortedArray();
            var result = solution.SortedSquares(new int[] { -7, -3, 2, 3, 11 });
            AssertHelper.AssertArray(new int[] { 4, 9, 9, 49, 121 }, result);
        }
    }
}
