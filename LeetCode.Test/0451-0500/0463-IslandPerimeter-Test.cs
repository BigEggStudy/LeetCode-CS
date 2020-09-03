using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0463_IslandPerimeter_Test
    {
        [TestMethod]
        public void IslandPerimeter_1()
        {
            var solution = new _0463_IslandPerimeter();
            var result = solution.IslandPerimeter(new int[][] {
                new int[] { 0, 1, 0, 0 },
                new int[] { 1, 1, 1, 0 },
                new int[] { 0, 1, 0, 0 },
                new int[] { 1, 1, 0, 0 },
            });
            Assert.AreEqual(16, result);
        }
    }
}
