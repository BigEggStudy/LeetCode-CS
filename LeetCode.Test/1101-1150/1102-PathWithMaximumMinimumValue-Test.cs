using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1102_PathWithMaximumMinimumValue_Test
    {
        [TestMethod]
        public void MaximumMinimumPath_1()
        {
            var solution = new _1102_PathWithMaximumMinimumValue();
            var result = solution.MaximumMinimumPath(new int[][] {
                new int[] { 5, 4, 5 },
                new int[] { 1, 2, 6 },
                new int[] { 7, 4, 6 },
            });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MaximumMinimumPath_2()
        {
            var solution = new _1102_PathWithMaximumMinimumValue();
            var result = solution.MaximumMinimumPath(new int[][] {
                new int[] { 2, 2, 1, 2, 2, 2 },
                new int[] { 1, 2, 2, 2, 1, 2 },
            });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MaximumMinimumPath_3()
        {
            var solution = new _1102_PathWithMaximumMinimumValue();
            var result = solution.MaximumMinimumPath(new int[][] {
                new int[] { 3, 4, 6, 3, 4 },
                new int[] { 0, 2, 1, 1, 7 },
                new int[] { 8, 8, 3, 2, 7 },
                new int[] { 3, 2, 4, 9, 8 },
                new int[] { 4, 1, 2, 0, 0 },
                new int[] { 4, 6, 5, 4, 3 },
            });
            Assert.AreEqual(3, result);
        }
    }
}
