using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0293_FlipGame_Test
    {
        [TestMethod]
        public void GeneratePossibleNextMoves_1()
        {
            var solution = new _0293_FlipGame();
            var result = solution.GeneratePossibleNextMoves("++++");
            AssertHelper.AssertList(new string[] { "--++", "+--+", "++--" }, result);
        }

        [TestMethod]
        public void GeneratePossibleNextMoves_2()
        {
            var solution = new _0293_FlipGame();
            var result = solution.GeneratePossibleNextMoves("+-+-");
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GeneratePossibleNextMoves_3()
        {
            var solution = new _0293_FlipGame();
            var result = solution.GeneratePossibleNextMoves("--");
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GeneratePossibleNextMoves_4()
        {
            var solution = new _0293_FlipGame();
            var result = solution.GeneratePossibleNextMoves("++");
            AssertHelper.AssertList(new string[] { "--" }, result);
        }
    }
}
