using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1062_LongestRepeatingSubstring_Test
    {
        [TestMethod]
        public void LongestRepeatingSubstring_1()
        {
            var solution = new _1062_LongestRepeatingSubstring();
            var result = solution.LongestRepeatingSubstring("abcd");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void LongestRepeatingSubstring_2()
        {
            var solution = new _1062_LongestRepeatingSubstring();
            var result = solution.LongestRepeatingSubstring("abbaba");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void LongestRepeatingSubstring_3()
        {
            var solution = new _1062_LongestRepeatingSubstring();
            var result = solution.LongestRepeatingSubstring("aabcaabdaab");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void LongestRepeatingSubstring_4()
        {
            var solution = new _1062_LongestRepeatingSubstring();
            var result = solution.LongestRepeatingSubstring("aaaaa");
            Assert.AreEqual(4, result);
        }
    }
}
