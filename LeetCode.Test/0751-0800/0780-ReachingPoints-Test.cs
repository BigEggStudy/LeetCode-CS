using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0780_ReachingPoints_Test
    {
        [TestMethod]
        public void ReachingPoints_1()
        {
            var solution = new _0780_ReachingPoints();
            var result = solution.ReachingPoints(1, 1, 3, 5);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ReachingPoints_2()
        {
            var solution = new _0780_ReachingPoints();
            var result = solution.ReachingPoints(1, 1, 2, 2);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ReachingPoints_3()
        {
            var solution = new _0780_ReachingPoints();
            var result = solution.ReachingPoints(1, 1, 1, 1);
            Assert.IsTrue(result);
        }
    }
}
