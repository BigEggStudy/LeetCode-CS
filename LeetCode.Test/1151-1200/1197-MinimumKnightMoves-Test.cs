using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1197_MinimumKnightMoves_Test
    {
        [TestMethod]
        public void MinKnightMovesTest_1()
        {
            var solution = new _1197_MinimumKnightMoves();
            var result = solution.MinKnightMoves(2, 1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MinKnightMovesTest_2()
        {
            var solution = new _1197_MinimumKnightMoves();
            var result = solution.MinKnightMoves(5, 5);
            Assert.AreEqual(4, result);
        }
    }
}
