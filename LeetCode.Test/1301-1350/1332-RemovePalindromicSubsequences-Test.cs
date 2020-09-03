using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1332_RemovePalindromicSubsequences_Test
    {
        [TestMethod]
        public void RemovePalindromeSub_1()
        {
            var solution = new _1332_RemovePalindromicSubsequences();
            var result = solution.RemovePalindromeSub("ababa");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void RemovePalindromeSub_2()
        {
            var solution = new _1332_RemovePalindromicSubsequences();
            var result = solution.RemovePalindromeSub("abb");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void RemovePalindromeSub_3()
        {
            var solution = new _1332_RemovePalindromicSubsequences();
            var result = solution.RemovePalindromeSub("baabb");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void RemovePalindromeSub_4()
        {
            var solution = new _1332_RemovePalindromicSubsequences();
            var result = solution.RemovePalindromeSub("");
            Assert.AreEqual(0, result);
        }
    }
}
