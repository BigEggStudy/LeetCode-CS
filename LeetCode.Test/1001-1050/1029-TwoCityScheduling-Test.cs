using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1029_TwoCityScheduling_Test
    {
        [TestMethod]
        public void TwoCitySchedCost_1()
        {
            var solution = new _1029_TwoCityScheduling();
            var result = solution.TwoCitySchedCost(new int[][] {
                new int[] { 10, 20 },
                new int[] { 30, 200 },
                new int[] { 400, 50 },
                new int[] { 30, 20 },
            });
            Assert.AreEqual(110, result);
        }
    }
}
