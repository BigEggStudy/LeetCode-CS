using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0490_TheMaze_Test
    {
        [TestMethod]
        public void HasPath_1()
        {
            var solution = new _0490_TheMaze();
            var result = solution.HasPath(new int[][] {
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 1, 0 },
                new int[] { 1, 1, 0, 1, 1 },
                new int[] { 0, 0, 0, 0, 0 },
            }, new int[] { 0, 4 }, new int[] { 4, 4 });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasPath_2()
        {
            var solution = new _0490_TheMaze();
            var result = solution.HasPath(new int[][] {
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 1, 0 },
                new int[] { 1, 1, 0, 1, 1 },
                new int[] { 0, 0, 0, 0, 0 },
            }, new int[] { 0, 4 }, new int[] { 3, 2 });
            Assert.IsFalse(result);
        }
    }
}
