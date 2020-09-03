using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0931_MinimumFallingPathSum_Test
    {
        [TestMethod]
        public void MinFallingPathSum_1()
        {
            var solution = new _0931_MinimumFallingPathSum();
            var result = solution.MinFallingPathSum(new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            });
            Assert.AreEqual(12, result);
        }
    }
}
