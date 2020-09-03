using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1041_RobotBoundedInCircle_Test
    {
        [TestMethod]
        public void IsRobotBounded_1()
        {
            var solution = new _1041_RobotBoundedInCircle();
            var result = solution.IsRobotBounded("GGLLGG");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRobotBounded_2()
        {
            var solution = new _1041_RobotBoundedInCircle();
            var result = solution.IsRobotBounded("GG");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsRobotBounded_3()
        {
            var solution = new _1041_RobotBoundedInCircle();
            var result = solution.IsRobotBounded("GL");
            Assert.IsTrue(result);
        }
    }
}
