using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0874_WalkingRobotSimulation_Test
    {
        [TestMethod]
        public void RobotSim_1()
        {
            var solution = new _0874_WalkingRobotSimulation();
            var result = solution.RobotSim(new int[] { 4, -1, 3 }, new int[][] { });
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void RobotSim_2()
        {
            var solution = new _0874_WalkingRobotSimulation();
            var result = solution.RobotSim(new int[] { 4, -1, 4, -2, 4 }, new int[][] { new int[] { 2, 4 } });
            Assert.AreEqual(65, result);
        }
    }
}
