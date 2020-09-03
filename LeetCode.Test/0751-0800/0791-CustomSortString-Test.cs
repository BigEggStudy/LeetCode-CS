using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0791_CustomSortString_Test
    {
        [TestMethod]
        public void CustomSortString_1()
        {
            var solution = new _0791_CustomSortString();
            var result = solution.CustomSortString("cba", "abcd");
            Assert.AreEqual("cbad", result);
        }
    }
}
