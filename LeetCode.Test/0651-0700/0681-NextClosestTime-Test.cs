using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0681_NextClosestTime_Test
    {
        [TestMethod]
        public void NextClosestTime_1()
        {
            var solution = new _0681_NextClosestTime();
            var result = solution.NextClosestTime("19:34");
            Assert.AreEqual("19:39", result);
        }

        [TestMethod]
        public void NextClosestTime_2()
        {
            var solution = new _0681_NextClosestTime();
            var result = solution.NextClosestTime("23:59");
            Assert.AreEqual("22:22", result);
        }

        [TestMethod]
        public void NextClosestTime_3()
        {
            var solution = new _0681_NextClosestTime();
            var result = solution.NextClosestTime("01:32");
            Assert.AreEqual("01:33", result);
        }
    }
}
