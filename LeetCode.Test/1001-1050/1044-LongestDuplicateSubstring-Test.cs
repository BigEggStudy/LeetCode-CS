using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1044_LongestDuplicateSubstring_Test
    {
        [TestMethod]
        public void LongestDupSubstring_1()
        {
            var solution = new _1044_LongestDuplicateSubstring();
            var result = solution.LongestDupSubstring("banana");
            Assert.AreEqual("ana", result);
        }

        [TestMethod]
        public void LongestDupSubstring_2()
        {
            var solution = new _1044_LongestDuplicateSubstring();
            var result = solution.LongestDupSubstring("abcd");
            Assert.AreEqual("", result);
        }
    }
}
