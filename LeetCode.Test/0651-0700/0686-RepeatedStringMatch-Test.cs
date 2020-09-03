using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0686_RepeatedStringMatch_Test
    {
        [TestMethod]
        public void RepeatedStringMatchTest()
        {
            var solution = new _0686_RepeatedStringMatch();
            var result = solution.RepeatedStringMatch("abcd", "cdabcdab");
            Assert.AreEqual(3, result);
        }
    }
}
