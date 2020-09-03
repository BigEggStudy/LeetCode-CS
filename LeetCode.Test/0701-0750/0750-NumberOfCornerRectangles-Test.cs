using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0750_NumberOfCornerRectangles_Test
    {
        [TestMethod]
        public void CountCornerRectangles_1()
        {
            var solution = new _0750_NumberOfCornerRectangles();
            var result = solution.CountCornerRectangles(new int[][] {
                new int[] { 1, 0, 0, 1, 0 },
                new int[] { 0, 0, 1, 0, 1 },
                new int[] { 0, 0, 0, 1, 0 },
                new int[] { 1, 0, 1, 0, 1 },
            });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CountCornerRectangles_2()
        {
            var solution = new _0750_NumberOfCornerRectangles();
            var result = solution.CountCornerRectangles(new int[][] {
                new int[] { 1, 1, 1 },
                new int[] { 1, 1, 1 },
                new int[] { 1, 1, 1 },
            });
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void CountCornerRectangles_3()
        {
            var solution = new _0750_NumberOfCornerRectangles();
            var result = solution.CountCornerRectangles(new int[][] {
                new int[] { 1, 1, 1, 1 },
            });
            Assert.AreEqual(0, result);
        }
    }
}
