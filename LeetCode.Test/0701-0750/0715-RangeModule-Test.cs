using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0715_RangeModule_Test
    {
        [TestMethod]
        public void RangeModuleTest_1()
        {
            var solution = new _0715_RangeModule();

            solution.AddRange(10, 20);
            solution.RemoveRange(14, 16);
            Assert.IsTrue(solution.QueryRange(10, 14));
            Assert.IsFalse(solution.QueryRange(13, 15));
            Assert.IsTrue(solution.QueryRange(16, 17));
        }
    }
}
