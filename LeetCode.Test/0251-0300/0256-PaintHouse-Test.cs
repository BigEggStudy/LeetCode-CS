using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0256_PaintHouse_Test
    {
        [TestMethod]
        public void MinCost_1()
        {
            var solution = new _0256_PaintHouse();
            var result = solution.MinCost(new int[][] {
                new int[] { 17, 2, 17 },
                new int[] { 16, 16, 5 },
                new int[] { 14, 3, 19 },
            });
            Assert.AreEqual(10, result);
        }
    }
}
