using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0857_MinimumCostToHireKWorkers_Test
    {
        [TestMethod]
        public void MincostToHireWorkersTest_1()
        {
            var solution = new _0857_MinimumCostToHireKWorkers();
            var result = solution.MincostToHireWorkers(new int[] { 10, 20, 5 }, new int[] { 70, 50, 30 }, 2);
            Assert.AreEqual(105.00000, result, 0.00001);
        }

        [TestMethod]
        public void MincostToHireWorkersTest_2()
        {
            var solution = new _0857_MinimumCostToHireKWorkers();
            var result = solution.MincostToHireWorkers(new int[] { 3, 1, 10, 10, 1 }, new int[] { 4, 8, 2, 2, 7 }, 3);
            Assert.AreEqual(30.66667, result, 0.00001);
        }

        [TestMethod]
        public void MincostToHireWorkersTest_3()
        {
            var solution = new _0857_MinimumCostToHireKWorkers();
            var result = solution.MincostToHireWorkers(new int[] { 4, 4, 4, 5 }, new int[] { 13, 12, 13, 12 }, 2);
            Assert.AreEqual(26, result, 0.00001);
        }
    }
}
