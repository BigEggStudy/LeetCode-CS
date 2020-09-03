using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0746_MinCostClimbingStairs_Test
    {
        [TestMethod]
        public void MinCostClimbingStairs_1()
        {
            var solution = new _0746_MinCostClimbingStairs();
            var result = solution.MinCostClimbingStairs(new int[] { 10, 15, 20 });
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void MinCostClimbingStairs_2()
        {
            var solution = new _0746_MinCostClimbingStairs();
            var result = solution.MinCostClimbingStairs(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 });
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void MinCostClimbingStairs_3()
        {
            var solution = new _0746_MinCostClimbingStairs();
            var result = solution.MinCostClimbingStairs(new int[] { 0,0,0,0 });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MinCostClimbingStairs_4()
        {
            var solution = new _0746_MinCostClimbingStairs();
            var result = solution.MinCostClimbingStairs(new int[] { 1, 2 });
            Assert.AreEqual(1, result);
        }
    }
}
