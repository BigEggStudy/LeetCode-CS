using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1271_Hexspeak_Test
    {
        [TestMethod]
        public void ToHexspeak_1()
        {
            var solution = new _1271_Hexspeak();
            var result = solution.ToHexspeak("257");
            Assert.AreEqual("IOI", result);
        }

        [TestMethod]
        public void ToHexspeak_2()
        {
            var solution = new _1271_Hexspeak();
            var result = solution.ToHexspeak("3");
            Assert.AreEqual("ERROR", result);
        }
    }
}
