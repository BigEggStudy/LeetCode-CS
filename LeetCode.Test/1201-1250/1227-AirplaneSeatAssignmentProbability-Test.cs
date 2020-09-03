using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1227_AirplaneSeatAssignmentProbability_Test
    {
        [TestMethod]
        public void NthPersonGetsNthSeat_1()
        {
            var solution = new _1227_AirplaneSeatAssignmentProbability();
            var result = solution.NthPersonGetsNthSeat(1);
            Assert.AreEqual(1.0, result);
        }

        [TestMethod]
        public void NthPersonGetsNthSeat_2()
        {
            var solution = new _1227_AirplaneSeatAssignmentProbability();
            var result = solution.NthPersonGetsNthSeat(2);
            Assert.AreEqual(0.5, result);
        }
    }
}
