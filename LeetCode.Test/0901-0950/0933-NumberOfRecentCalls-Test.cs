using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0933_NumberOfRecentCalls_Test
    {
        [TestMethod]
        public void PingTest_1()
        {
            var solution = new _0933_NumberOfRecentCalls();
            var result = solution.Ping(1);
            Assert.AreEqual(1, result);

            result = solution.Ping(100);
            Assert.AreEqual(2, result);

            result = solution.Ping(3001);
            Assert.AreEqual(3, result);

            result = solution.Ping(3002);
            Assert.AreEqual(3, result);
        }
    }
}
