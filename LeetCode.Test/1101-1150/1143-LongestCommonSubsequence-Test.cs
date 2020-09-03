using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1143_LongestCommonSubsequence_Test
    {
        [TestMethod]
        public void LongestCommonSubsequence_1()
        {
            var solution = new _1143_LongestCommonSubsequence();
            var result = solution.LongestCommonSubsequence("abcde", "ace");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void LongestCommonSubsequence_2()
        {
            var solution = new _1143_LongestCommonSubsequence();
            var result = solution.LongestCommonSubsequence("abc", "abc");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void LongestCommonSubsequence_3()
        {
            var solution = new _1143_LongestCommonSubsequence();
            var result = solution.LongestCommonSubsequence("abc", "def");
            Assert.AreEqual(0, result);
        }
    }
}
