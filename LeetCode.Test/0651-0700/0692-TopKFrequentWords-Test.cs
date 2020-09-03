using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0692_TopKFrequentWords_Test
    {
        [TestMethod]
        public void TopKFrequent_1()
        {
            var solution = new _0692_TopKFrequentWords();
            var result = solution.TopKFrequent(new string[] { "i", "love", "leetcode", "i", "love", "coding" }, 2);
            AssertHelper.AssertList(new string[] { "i", "love" }, result);
        }

        [TestMethod]
        public void TopKFrequent_2()
        {
            var solution = new _0692_TopKFrequentWords();
            var result = solution.TopKFrequent(new string[] { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" }, 4);
            AssertHelper.AssertList(new string[] { "the", "is", "sunny", "day" }, result);
        }
    }
}
