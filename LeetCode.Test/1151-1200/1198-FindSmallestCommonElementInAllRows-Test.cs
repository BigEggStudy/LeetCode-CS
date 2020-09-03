using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1198_FindSmallestCommonElementInAllRows_Test
    {
        [TestMethod]
        public void SmallestCommonElement_1()
        {
            var solution = new _1198_FindSmallestCommonElementInAllRows();
            var result = solution.SmallestCommonElement(new int[][] {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 2, 4, 5, 8, 10 },
                new int[] { 3, 5, 7, 9, 11 },
                new int[] { 1, 3, 5, 7, 9 },
            });
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void SmallestCommonElement_2()
        {
            var solution = new _1198_FindSmallestCommonElementInAllRows();
            var result = solution.SmallestCommonElement(new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 2, 3, 4 },
                new int[] { 2, 3, 5 },
            });
            Assert.AreEqual(2, result);
        }
    }
}
