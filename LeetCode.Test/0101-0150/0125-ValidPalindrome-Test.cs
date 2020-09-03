using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0125_ValidPalindrome_Test
    {
        [TestMethod]
        public void IsPalindromeTest_1()
        {
            var solution = new _0125_ValidPalindrome();
            Assert.IsTrue(solution.IsPalindrome("A man, a plan, a canal: Panama"));
        }

        [TestMethod]
        public void IsPalindromeTest_2()
        {
            var solution = new _0125_ValidPalindrome();
            Assert.IsFalse(solution.IsPalindrome("race a car"));
        }

        [TestMethod]
        public void IsPalindromeTest_3()
        {
            var solution = new _0125_ValidPalindrome();
            Assert.IsTrue(solution.IsPalindrome(string.Empty));
        }

        [TestMethod]
        public void IsPalindromeTest_4()
        {
            var solution = new _0125_ValidPalindrome();
            Assert.IsTrue(solution.IsPalindrome("."));
        }

        [TestMethod]
        public void IsPalindromeTest_5()
        {
            var solution = new _0125_ValidPalindrome();
            Assert.IsFalse(solution.IsPalindrome("0P"));
        }
    }
}
