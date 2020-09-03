using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0807_MaxIncreaseToKeepCitySkyline_Test
    {
        [TestMethod]
        public void MaxIncreaseKeepingSkyline_1()
        {
            var solution = new _0807_MaxIncreaseToKeepCitySkyline();
            var result = solution.MaxIncreaseKeepingSkyline(new int[][] {
                new int[] { 3, 0, 8, 4 },
                new int[] { 2, 4, 5, 7 },
                new int[] { 9, 2, 6, 3 },
                new int[] { 0, 3, 1, 0 },
            });
            Assert.AreEqual(35, result);
        }
    }
}
