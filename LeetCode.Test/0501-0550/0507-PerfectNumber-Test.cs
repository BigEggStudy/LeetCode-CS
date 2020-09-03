using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0507_PerfectNumber_Test
    {
        [TestMethod]
        public void CheckPerfectNumber_1()
        {
            var solution = new _0507_PerfectNumber();
            var result = solution.CheckPerfectNumber(28);
            Assert.IsTrue(result);
        }
    }
}
