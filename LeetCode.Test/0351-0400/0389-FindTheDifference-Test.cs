using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0389_FindTheDifference_Test
    {
        [TestMethod]
        public void FindTheDifference_1()
        {
            var solution = new _0389_FindTheDifference();
            var result = solution.FindTheDifference("abcd", "abcde");
            Assert.AreEqual('e', result);
        }

        [TestMethod]
        public void FindTheDifference_2()
        {
            var solution = new _0389_FindTheDifference();
            var result = solution.FindTheDifference("abcd", "bedac");
            Assert.AreEqual('e', result);
        }
    }
}
