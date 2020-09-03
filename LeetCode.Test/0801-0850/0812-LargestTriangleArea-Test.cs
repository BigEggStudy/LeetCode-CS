using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0812_LargestTriangleArea_Test
    {
        [TestMethod]
        public void LargestTriangleArea_1()
        {
            var solution = new _0812_LargestTriangleArea();
            var result = solution.LargestTriangleArea(new int[][] {
                new int[] { 0, 0 },
                new int[] { 0, 1 },
                new int[] { 1, 0 },
                new int[] { 0, 2 },
                new int[] { 2, 0 },
            });
            Assert.AreEqual(2, result);
        }
    }
}
