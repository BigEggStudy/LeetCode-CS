using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1061_LexicographicallySmallestEquivalentString_Test
    {
        [TestMethod]
        public void SmallestEquivalentString_1()
        {
            var solution = new _1061_LexicographicallySmallestEquivalentString();
            var result = solution.SmallestEquivalentString("parker", "morris", "parser");
            Assert.AreEqual("makkek", result);
        }

        [TestMethod]
        public void SmallestEquivalentString_2()
        {
            var solution = new _1061_LexicographicallySmallestEquivalentString();
            var result = solution.SmallestEquivalentString("hello", "world", "hold");
            Assert.AreEqual("hdld", result);
        }

        [TestMethod]
        public void SmallestEquivalentString_3()
        {
            var solution = new _1061_LexicographicallySmallestEquivalentString();
            var result = solution.SmallestEquivalentString("leetcode", "programs", "sourcecode");
            Assert.AreEqual("aauaaaaada", result);
        }
    }
}
