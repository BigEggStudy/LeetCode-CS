using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0787_CheapestFlightsWithinKStops_Test
    {
        [TestMethod]
        public void FindCheapestPrice_1()
        {
            var solution = new _0787_CheapestFlightsWithinKStops();
            var result = solution.FindCheapestPrice(3, new int[][] {
                new int[] { 0, 1, 100 },
                new int[] { 1, 2, 100 },
                new int[] { 0, 2, 500 },
            }, 0, 2, 1);
            Assert.AreEqual(200, result);
        }

        [TestMethod]
        public void FindCheapestPrice_2()
        {
            var solution = new _0787_CheapestFlightsWithinKStops();
            var result = solution.FindCheapestPrice(3, new int[][] {
                new int[] { 0, 1, 100 },
                new int[] { 1, 2, 100 },
                new int[] { 0, 2, 500 },
            }, 0, 2, 0);
            Assert.AreEqual(500, result);
        }
    }
}
