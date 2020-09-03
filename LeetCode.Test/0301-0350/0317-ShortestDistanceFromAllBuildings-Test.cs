using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0317_ShortestDistanceFromAllBuildings_Test
    {
        [TestMethod]
        public void ShortestDistance_1()
        {
            var solution = new _0317_ShortestDistanceFromAllBuildings();
            var result = solution.ShortestDistance(new int[][] {
                new int[] { 1, 0, 2, 0, 1 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 },
            });
            Assert.AreEqual(7, result);
        }
    }
}
