using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0278_FirstBadVersion_Test
    {
        [TestMethod]
        public void FirstBadVersion_1()
        {
            var solution = new _0278_FirstBadVersion();
            var result = solution.FirstBadVersion(5);
            Assert.AreEqual(4, result);
        }
    }
}
