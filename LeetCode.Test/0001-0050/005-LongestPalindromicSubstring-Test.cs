using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _005_LongestPalindromicSubstring_Test
    {
        [TestMethod]
        public void LongestPalindromeTest_Odd()
        {
            var input = "abcdefgfedcba";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("abcdefgfedcba", result);
        }

        [TestMethod]
        public void LongestPalindromeTest_Even()
        {
            var input = "abcdefggfedcba";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("abcdefggfedcba", result);
        }

        [TestMethod]
        public void LongestPalindromeTest_AllTheSame_Odd()
        {
            var input = "ccc";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("ccc", result);
        }

        [TestMethod]
        public void LongestPalindromeTest_AllTheSame_Even()
        {
            var input = "aaaaaaaaaa";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("aaaaaaaaaa", result);
        }

        [TestMethod]
        public void LongestPalindromeTest_EmptyString()
        {
            var input = "";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void LongestPalindromeTest_OneCharacterString()
        {
            var input = "a";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void LongestPalindromeTest_MultiplePalindrome_LongestAtStart()
        {
            var input = "aabccdccbaaeeggee";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("aabccdccbaa", result);
        }

        [TestMethod]
        public void LongestPalindromeTest_MultiplePalindrome_LongestAtEnd()
        {
            var input = "eegffgeeaabcdcbaa";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("aabcdcbaa", result);
        }

        [TestMethod]
        public void LongestPalindromeTest_MultipleMixPalindrome()
        {
            var input = "abcdcbbcd";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("dcbbcd", result);
        }

        [TestMethod]
        public void LongestPalindromeTest_MultipleMixPalindrome_2()
        {
            var input = "abcddcbebcd";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.AreEqual("dcbebcd", result);
        }
    }
}
