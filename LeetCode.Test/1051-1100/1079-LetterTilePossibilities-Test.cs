using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1079_LetterTilePossibilities_Test
    {
        [TestMethod]
        public void NumTilePossibilities_1()
        {
            var solution = new _1079_LetterTilePossibilities();
            var result = solution.NumTilePossibilities("AAB");
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void NumTilePossibilities_2()
        {
            var solution = new _1079_LetterTilePossibilities();
            var result = solution.NumTilePossibilities("AAABBC");
            Assert.AreEqual(188, result);
        }
    }
}
