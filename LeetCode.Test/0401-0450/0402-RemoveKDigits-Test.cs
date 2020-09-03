using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0402_RemoveKDigits_Test
    {
        [TestMethod]
        public void RemoveKdigits_1()
        {
            var solution = new _0402_RemoveKDigits();
            var result = solution.RemoveKdigits("1432219", 3);
            Assert.AreEqual("1219", result);
        }

        [TestMethod]
        public void RemoveKdigits_2()
        {
            var solution = new _0402_RemoveKDigits();
            var result = solution.RemoveKdigits("10200", 1);
            Assert.AreEqual("200", result);
        }

        [TestMethod]
        public void RemoveKdigits_3()
        {
            var solution = new _0402_RemoveKDigits();
            var result = solution.RemoveKdigits("10", 2);
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void RemoveKdigits_4()
        {
            var solution = new _0402_RemoveKDigits();
            var result = solution.RemoveKdigits("10", 1);
            Assert.AreEqual("0", result);
        }
    }
}
