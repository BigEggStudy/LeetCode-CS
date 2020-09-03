using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0529_Minesweeper_Test
    {
        [TestMethod]
        public void UpdateBoard_1()
        {
            var solution = new _0529_Minesweeper();
            var result = solution.UpdateBoard(new char[][] {
                new char[] { 'E', 'E', 'E', 'E', 'E' },
                new char[] { 'E', 'E', 'M', 'E', 'E' },
                new char[] { 'E', 'E', 'E', 'E', 'E' },
                new char[] { 'E', 'E', 'E', 'E', 'E' },
            }, new int[] { 3, 0 });
            AssertHelper.AssertArray(new char[][] {
                new char[] { 'B', '1', 'E', '1', 'B' },
                new char[] { 'B', '1', 'M', '1', 'B' },
                new char[] { 'B', '1', '1', '1', 'B' },
                new char[] { 'B', 'B', 'B', 'B', 'B' },
            }, result);
        }

        [TestMethod]
        public void UpdateBoard_2()
        {
            var solution = new _0529_Minesweeper();
            var result = solution.UpdateBoard(new char[][] {
                new char[] { 'B', '1', 'E', '1', 'B' },
                new char[] { 'B', '1', 'M', '1', 'B' },
                new char[] { 'B', '1', '1', '1', 'B' },
                new char[] { 'B', 'B', 'B', 'B', 'B' },
            }, new int[] { 1, 2 });
            AssertHelper.AssertArray(new char[][] {
                new char[] { 'B', '1', 'E', '1', 'B' },
                new char[] { 'B', '1', 'X', '1', 'B' },
                new char[] { 'B', '1', '1', '1', 'B' },
                new char[] { 'B', 'B', 'B', 'B', 'B' },
            }, result);
        }
    }
}
