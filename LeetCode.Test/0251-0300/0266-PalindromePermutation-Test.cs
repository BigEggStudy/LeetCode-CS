using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0266_PalindromePermutation_Test
    {
        [TestMethod]
        public void CanPermutePalindrome_1()
        {
            var solution = new _0266_PalindromePermutation();
            var result = solution.CanPermutePalindrome("code");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanPermutePalindrome_2()
        {
            var solution = new _0266_PalindromePermutation();
            var result = solution.CanPermutePalindrome("aab");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanPermutePalindrome_3()
        {
            var solution = new _0266_PalindromePermutation();
            var result = solution.CanPermutePalindrome("carerac");
            Assert.IsTrue(result);
        }
    }
}
