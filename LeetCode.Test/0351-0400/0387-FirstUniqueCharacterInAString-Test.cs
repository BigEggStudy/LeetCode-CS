using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0387_FirstUniqueCharacterInAString_Test
    {
        [TestMethod]
        public void FirstUniqChar_1()
        {
            var solution = new _0387_FirstUniqueCharacterInAString();
            var result = solution.FirstUniqChar("leetcode");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FirstUniqChar_2()
        {
            var solution = new _0387_FirstUniqueCharacterInAString();
            var result = solution.FirstUniqChar("loveleetcode");
            Assert.AreEqual(2, result);
        }
    }
}
