using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0616_AddBoldTagInString_Test
    {
        [TestMethod]
        public void AddBoldTag_1()
        {
            var solution = new _0616_AddBoldTagInString();
            var result = solution.AddBoldTag("aabcd", new string[] { "ab", "bc" });
            Assert.AreEqual("a<b>abc</b>d", result);
        }

        [TestMethod]
        public void AddBoldTag_2()
        {
            var solution = new _0616_AddBoldTagInString();
            var result = solution.AddBoldTag("abcxyz123", new string[] { "abc", "123" });
            Assert.AreEqual("<b>abc</b>xyz<b>123</b>", result);
        }

        [TestMethod]
        public void AddBoldTag_3()
        {
            var solution = new _0616_AddBoldTagInString();
            var result = solution.AddBoldTag("aaabbcc", new string[] { "aaa", "aab", "bc" });
            Assert.AreEqual("<b>aaabbc</b>c", result);
        }
    }
}
