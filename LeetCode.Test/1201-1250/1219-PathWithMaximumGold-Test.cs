using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1219_PathWithMaximumGold_Test
    {
        [TestMethod]
        public void GetMaximumGold_1()
        {
            var solution = new _1219_PathWithMaximumGold();
            var result = solution.GetMaximumGold(new int[][] {
                new int[] { 0, 6, 0 },
                new int[] { 5, 8, 7 },
                new int[] { 0, 9, 0 },
            });
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void GetMaximumGold_2()
        {
            var solution = new _1219_PathWithMaximumGold();
            var result = solution.GetMaximumGold(new int[][] {
                new int[] { 1, 0, 7 },
                new int[] { 2, 0, 6 },
                new int[] { 3, 4, 5 },
                new int[] { 0, 3, 0 },
                new int[] { 9, 0, 20 },
            });
            Assert.AreEqual(28, result);
        }
    }
}
