using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1413_MinimumValueToGetPositiveStepByStepSum_Test
    {
        [TestMethod]
        public void MinStartValue_1()
        {
            var solution = new _1413_MinimumValueToGetPositiveStepByStepSum();
            var result = solution.MinStartValue(new int[] { -3, 2, -3, 4, 2 });
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void MinStartValue_2()
        {
            var solution = new _1413_MinimumValueToGetPositiveStepByStepSum();
            var result = solution.MinStartValue(new int[] { 1, 2 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MinStartValue_3()
        {
            var solution = new _1413_MinimumValueToGetPositiveStepByStepSum();
            var result = solution.MinStartValue(new int[] { 1, -2, -3 });
            Assert.AreEqual(5, result);
        }
    }
}
