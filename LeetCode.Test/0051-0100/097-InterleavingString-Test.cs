using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _097_InterleavingString_Test
    {
        [TestMethod]
        public void IsInterleaveTest()
        {
            var solution = new _097_InterleavingString();
            Assert.IsTrue(solution.IsInterleave("aabcc", "dbbca", "aadbbcbcac"));
            Assert.IsFalse(solution.IsInterleave("aabcc", "dbbca", "aadbbbaccc"));
        }

        [TestMethod]
        public void IsInterleaveTest_NotSameSize()
        {
            var solution = new _097_InterleavingString();
            Assert.IsFalse(solution.IsInterleave("aabcc", "dbbca", "aadbbcbcaca"));
            Assert.IsFalse(solution.IsInterleave("aabcc", "dbbca", "aadbbbaccca"));
        }
    }
}
