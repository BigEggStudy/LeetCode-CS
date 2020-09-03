using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0833_FindAndReplaceInString_Test
    {
        [TestMethod]
        public void FindReplaceStringTest_1()
        {
            var solution = new _0833_FindAndReplaceInString();
            var result = solution.FindReplaceString("abcd", new int[] { 0, 2 }, new string[] { "a", "cd" }, new string[] { "eee", "ffff" });
            Assert.AreEqual("eeebffff", result);
        }

        [TestMethod]
        public void FindReplaceStringTest_2()
        {
            var solution = new _0833_FindAndReplaceInString();
            var result = solution.FindReplaceString("abcd", new int[] { 0, 2 }, new string[] { "ab", "ec" }, new string[] { "eee", "ffff" });
            Assert.AreEqual("eeecd", result);
        }
    }
}
