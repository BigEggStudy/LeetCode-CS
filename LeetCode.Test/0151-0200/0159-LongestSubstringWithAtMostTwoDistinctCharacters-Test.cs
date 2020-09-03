using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0159_LongestSubstringWithAtMostTwoDistinctCharacters_Test
    {
        [TestMethod]
        public void LengthOfLongestSubstringTwoDistinctTest_1()
        {
            var solution = new _0159_LongestSubstringWithAtMostTwoDistinctCharacters();
            var result = solution.LengthOfLongestSubstringTwoDistinct("eceba");
            Assert.AreEqual(3, result);
        }


        [TestMethod]
        public void LengthOfLongestSubstringTwoDistinctTest_2()
        {
            var solution = new _0159_LongestSubstringWithAtMostTwoDistinctCharacters();
            var result = solution.LengthOfLongestSubstringTwoDistinct("ccaabbb");
            Assert.AreEqual(5, result);
        }
    }
}
