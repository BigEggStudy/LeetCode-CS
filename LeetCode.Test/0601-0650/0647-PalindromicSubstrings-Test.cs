using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0647_PalindromicSubstrings_Test
    {
        [TestMethod]
        public void CountSubstrings_1()
        {
            var solution = new _0647_PalindromicSubstrings();
            var result = solution.CountSubstrings("abc");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CountSubstrings_2()
        {
            var solution = new _0647_PalindromicSubstrings();
            var result = solution.CountSubstrings("aaa");
            Assert.AreEqual(6, result);
        }
    }
}
