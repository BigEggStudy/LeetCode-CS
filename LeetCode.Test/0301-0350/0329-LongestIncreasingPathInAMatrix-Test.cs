using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0329_LongestIncreasingPathInAMatrix_Test
    {
        [TestMethod]
        public void LongestIncreasingPathTest_1()
        {
            var solution = new _0329_LongestIncreasingPathInAMatrix();
            var result = solution.LongestIncreasingPath(new int[][]
            {
                new int[] { 9, 9, 4 },
                new int[] { 6, 6, 8 },
                new int[] { 2, 1, 1 },
            });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void LongestIncreasingPathTest_2()
        {
            var solution = new _0329_LongestIncreasingPathInAMatrix();
            var result = solution.LongestIncreasingPath(new int[][]
            {
                new int[] { 3, 4, 5 },
                new int[] { 3, 2, 6 },
                new int[] { 2, 2, 1 },
            });
            Assert.AreEqual(4, result);
        }
    }
}
