using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1170_CompareStringsByFrequencyOfTheSmallestCharacter_Test
    {
        [TestMethod]
        public void NumSmallerByFrequency_1()
        {
            var solution = new _1170_CompareStringsByFrequencyOfTheSmallestCharacter();
            var result = solution.NumSmallerByFrequency(new string[] { "cbd" }, new string[] { "zaaaz" });
            AssertHelper.AssertArray(new int[] { 1 }, result);
        }

        [TestMethod]
        public void NumSmallerByFrequency_2()
        {
            var solution = new _1170_CompareStringsByFrequencyOfTheSmallestCharacter();
            var result = solution.NumSmallerByFrequency(new string[] { "bbb", "cc" }, new string[] { "a", "aa", "aaa", "aaaa" });
            AssertHelper.AssertArray(new int[] { 1, 2 }, result);
        }
    }
}
