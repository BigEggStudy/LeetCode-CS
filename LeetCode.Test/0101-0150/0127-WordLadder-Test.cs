using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0127_WordLadder_Test
    {
        [TestMethod]
        public void LadderLengthTest_1()
        {
            var solution = new _0127_WordLadder();
            var result = solution.LadderLength("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log", "cog" });
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void LadderLengthTest_2()
        {
            var solution = new _0127_WordLadder();
            var result = solution.LadderLength("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log" });
            Assert.AreEqual(0, result);
        }
    }
}
