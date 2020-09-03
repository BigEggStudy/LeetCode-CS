using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0139_WordBreak_Test
    {
        [TestMethod]
        public void WordBreakTest_1()
        {
            var solution = new _0139_WordBreak();
            var result = solution.WordBreak("leetcode", new string[] { "leet", "code" });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void WordBreakTest_2()
        {
            var solution = new _0139_WordBreak();
            var result = solution.WordBreak("applepenapple", new string[] { "apple", "pen" });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void WordBreakTest_3()
        {
            var solution = new _0139_WordBreak();
            var result = solution.WordBreak("catsandog", new string[] { "cats", "dog", "sand", "and", "cat" });
            Assert.IsFalse(result);
        }
    }
}
