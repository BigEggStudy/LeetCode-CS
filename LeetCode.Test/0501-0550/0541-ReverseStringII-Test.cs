using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0541_ReverseStringII_Test
    {
        [TestMethod]
        public void ReverseStr_1()
        {
            var solution = new _0541_ReverseStringII();
            var result = solution.ReverseStr("abcdefg", 2);
            Assert.AreEqual("bacdfeg", result);
        }

        [TestMethod]
        public void ReverseStr_2()
        {
            var solution = new _0541_ReverseStringII();
            var result = solution.ReverseStr("a", 2);
            Assert.AreEqual("a", result);
        }
    }
}
