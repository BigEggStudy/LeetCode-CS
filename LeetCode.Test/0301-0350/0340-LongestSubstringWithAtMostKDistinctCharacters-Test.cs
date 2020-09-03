using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0340_LongestSubstringWithAtMostKDistinctCharacters_Test
    {
        [TestMethod]
        public void LengthOfLongestSubstringKDistinct_1()
        {
            var solution = new _0340_LongestSubstringWithAtMostKDistinctCharacters();
            var result = solution.LengthOfLongestSubstringKDistinct("eceba", 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstringKDistinct_2()
        {
            var solution = new _0340_LongestSubstringWithAtMostKDistinctCharacters();
            var result = solution.LengthOfLongestSubstringKDistinct("aa", 1);
            Assert.AreEqual(2, result);
        }
    }
}
