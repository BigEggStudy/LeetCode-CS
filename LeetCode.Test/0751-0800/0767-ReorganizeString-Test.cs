using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0767_ReorganizeString_Test
    {
        [TestMethod]
        public void ReorganizeString_1()
        {
            var solution = new _0767_ReorganizeString();
            var result = solution.ReorganizeString("aab");
            Assert.AreEqual("aba", result);
        }

        [TestMethod]
        public void ReorganizeString_2()
        {
            var solution = new _0767_ReorganizeString();
            var result = solution.ReorganizeString("aaab");
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void ReorganizeString_3()
        {
            var solution = new _0767_ReorganizeString();
            var result = solution.ReorganizeString("vvvlo");
            Assert.AreEqual("vovlv", result);
        }
    }
}
