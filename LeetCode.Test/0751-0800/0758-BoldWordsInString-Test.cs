using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0758_BoldWordsInString_Test
    {
        [TestMethod]
        public void BoldWords_1()
        {
            var solution = new _0758_BoldWordsInString();
            var result = solution.BoldWords(new string[] { "ab", "bc" }, "aabcd");
            Assert.AreEqual("a<b>abc</b>d", result);
        }

        [TestMethod]
        public void BoldWords_2()
        {
            var solution = new _0758_BoldWordsInString();
            var result = solution.BoldWords(new string[] { "abc", "123" }, "abcxyz123");
            Assert.AreEqual("<b>abc</b>xyz<b>123</b>", result);
        }

        [TestMethod]
        public void BoldWords_3()
        {
            var solution = new _0758_BoldWordsInString();
            var result = solution.BoldWords(new string[] { "aaa", "aab", "bc" }, "aaabbcc");
            Assert.AreEqual("<b>aaabbc</b>c", result);
        }
    }
}
