using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0211_AddAndSearchWordDataStructureDesign_Test
    {
        [TestMethod]
        public void WordDictionary_1()
        {
            var solution = new _0211_AddAndSearchWordDataStructureDesign();

            solution.AddWord("bad");
            solution.AddWord("dad");
            solution.AddWord("mad");
            Assert.IsFalse(solution.Search("pad"));
            Assert.IsTrue(solution.Search("bad"));
            Assert.IsTrue(solution.Search(".ad"));
            Assert.IsTrue(solution.Search("b.."));
        }

        [TestMethod]
        public void WordDictionary_2()
        {
            var solution = new _0211_AddAndSearchWordDataStructureDesign();

            solution.AddWord("a");
            solution.AddWord("a");
            Assert.IsTrue(solution.Search("a"));
            Assert.IsTrue(solution.Search("."));
            Assert.IsFalse(solution.Search("aa"));
            Assert.IsTrue(solution.Search("a"));
            Assert.IsFalse(solution.Search(".a"));
            Assert.IsFalse(solution.Search("a."));
        }
    }
}
