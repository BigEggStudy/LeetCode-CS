using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1408_StringMatchingInAnArray_Test
    {
        [TestMethod]
        public void StringMatching_1()
        {
            var solution = new _1408_StringMatchingInAnArray();
            var result = solution.StringMatching(new string[] { "mass", "as", "hero", "superhero" });
            AssertHelper.AssertList(new string[] { "as", "hero" }, result);
        }

        [TestMethod]
        public void StringMatching_2()
        {
            var solution = new _1408_StringMatchingInAnArray();
            var result = solution.StringMatching(new string[] { "leetcode", "et", "code" });
            AssertHelper.AssertList(new string[] { "et", "code" }, result);
        }

        [TestMethod]
        public void StringMatching_3()
        {
            var solution = new _1408_StringMatchingInAnArray();
            var result = solution.StringMatching(new string[] { "blue", "green", "bu" });
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void StringMatching_4()
        {
            var solution = new _1408_StringMatchingInAnArray();
            var result = solution.StringMatching(new string[] { "leetcoder", "leetcode", "od", "hamlet", "am" });
            AssertHelper.AssertList(new string[] { "od", "am", "leetcode" }, result);
        }
    }
}
