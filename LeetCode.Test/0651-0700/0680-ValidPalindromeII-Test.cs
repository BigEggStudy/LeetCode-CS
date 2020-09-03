using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0680_ValidPalindromeII_Test
    {
        [TestMethod]
        public void ValidPalindrome_1()
        {
            var solution = new _0680_ValidPalindromeII();
            var result = solution.ValidPalindrome("aba");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidPalindrome_2()
        {
            var solution = new _0680_ValidPalindromeII();
            var result = solution.ValidPalindrome("abca");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidPalindrome_3()
        {
            var solution = new _0680_ValidPalindromeII();
            var result = solution.ValidPalindrome("abc");
            Assert.IsFalse(result);
        }
    }
}
