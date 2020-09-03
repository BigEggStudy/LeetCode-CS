using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _014_LongestCommonPrefix_Test
    {
        [TestMethod]
        public void LongestCommonPrefixTest_Empty()
        {
            var solution = new _014_LongestCommonPrefix();

            var result = solution.LongestCommonPrefix(new string[0]);
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void LongestCommonPrefixTest_OneString()
        {
            var solution = new _014_LongestCommonPrefix();

            var result = solution.LongestCommonPrefix(new string[1] { "abc" });
            Assert.AreEqual("abc", result);
        }

        [TestMethod]
        public void LongestCommonPrefixTest_HavePrefix()
        {
            var solution = new _014_LongestCommonPrefix();

            var result = solution.LongestCommonPrefix(new string[2] { "aa", "a" });
            Assert.AreEqual("a", result);

            result = solution.LongestCommonPrefix(new string[2] { "a", "aa" });
            Assert.AreEqual("a", result);

            result = solution.LongestCommonPrefix(new string[3] { "abcd", "abc", "abd" });
            Assert.AreEqual("ab", result);
        }

        [TestMethod]
        public void LongestCommonPrefixTest_NoPrefix()
        {
            var solution = new _014_LongestCommonPrefix();

            var result = solution.LongestCommonPrefix(new string[3] { "abc", "abd", "bcd" });
            Assert.AreEqual(string.Empty, result);
        }
    }
}
