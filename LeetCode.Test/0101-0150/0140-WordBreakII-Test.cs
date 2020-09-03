using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0140_WordBreakII_Test
    {
        [TestMethod]
        public void WordBreak_1()
        {
            var solution = new _0140_WordBreakII();
            var result = solution.WordBreak("catsanddog", new string[] { "cat", "cats", "and", "sand", "dog" });
            AssertHelper.AssertList(new string[] {
                "cat sand dog",
                "cats and dog",
            }, result);
        }

        [TestMethod]
        public void WordBreak_2()
        {
            var solution = new _0140_WordBreakII();
            var result = solution.WordBreak("pineapplepenapple", new string[] { "apple", "pen", "applepen", "pine", "pineapple" });
            AssertHelper.AssertList(new string[] {
                "pine applepen apple",
                "pineapple pen apple",
                "pine apple pen apple",
            }, result);
        }

        [TestMethod]
        public void WordBreak_3()
        {
            var solution = new _0140_WordBreakII();
            var result = solution.WordBreak("catsandog", new string[] { "cats", "dog", "sand", "and", "cat" });
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        [Timeout(20)]
        public void WordBreak_4()
        {
            var results = new string[] { "a a a a a a a", "aa a a a a a", "a aa a a a a", "a a aa a a a", "aa aa a a a", "aaaa a a a", "a a a aa a a", "aa a aa a a", "a aa aa a a", "a aaaa a a", "a a a a aa a", "aa a a aa a", "a aa a aa a", "a a aa aa a", "aa aa aa a", "aaaa aa a", "a a aaaa a", "aa aaaa a", "a a a a a aa", "aa a a a aa", "a aa a a aa", "a a aa a aa", "aa aa a aa", "aaaa a aa", "a a a aa aa", "aa a aa aa", "a aa aa aa", "a aaaa aa", "a a a aaaa", "aa a aaaa", "a aa aaaa" };

            var solution = new _0140_WordBreakII();
            var result = solution.WordBreak("aaaaaaa", new string[] { "aaaa", "aa", "a" });
            Assert.AreEqual(results.Length, result.Count);
        }
    }
}
