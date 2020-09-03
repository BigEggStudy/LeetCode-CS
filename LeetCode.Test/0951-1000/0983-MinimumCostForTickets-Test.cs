using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0983_MinimumCostForTickets_Test
    {
        [TestMethod]
        public void MincostTickets_1()
        {
            var solution = new _0983_MinimumCostForTickets();
            var result = solution.MincostTickets(new int[] { 1, 4, 6, 7, 8, 20 }, new int[] { 2, 7, 15 });
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void MincostTickets_2()
        {
            var solution = new _0983_MinimumCostForTickets();
            var result = solution.MincostTickets(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31 }, new int[] { 2, 7, 15 });
            Assert.AreEqual(17, result);
        }
    }
}
