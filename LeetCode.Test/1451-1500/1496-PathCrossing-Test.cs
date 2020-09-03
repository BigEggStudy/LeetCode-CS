using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1496_PathCrossing_Test
    {
        [TestMethod]
        public void IsPathCrossing_1()
        {
            var solution = new _1496_PathCrossing();
            var result = solution.IsPathCrossing("NES");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPathCrossing_2()
        {
            var solution = new _1496_PathCrossing();
            var result = solution.IsPathCrossing("NESWW");
            Assert.IsTrue(result);
        }
    }
}
