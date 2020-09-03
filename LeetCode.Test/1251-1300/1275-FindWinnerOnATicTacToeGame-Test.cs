using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1275_FindWinnerOnATicTacToeGame_Test
    {
        [TestMethod]
        public void Tictactoe_1()
        {
            var solution = new _1275_FindWinnerOnATicTacToeGame();
            var result = solution.Tictactoe(new int[][] {
                new int[] { 0, 0 },
                new int[] { 2, 0 },
                new int[] { 1, 1 },
                new int[] { 2, 1 },
                new int[] { 2, 2 },
            });
            Assert.AreEqual("A", result);
        }

        [TestMethod]
        public void Tictactoe_2()
        {
            var solution = new _1275_FindWinnerOnATicTacToeGame();
            var result = solution.Tictactoe(new int[][] {
                new int[] { 0, 0 },
                new int[] { 1, 1 },
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 1, 0 },
                new int[] { 2, 0 },
            });
            Assert.AreEqual("B", result);
        }

        [TestMethod]
        public void Tictactoe_3()
        {
            var solution = new _1275_FindWinnerOnATicTacToeGame();
            var result = solution.Tictactoe(new int[][] {
                new int[] { 0, 0 },
                new int[] { 1, 1 },
                new int[] { 2, 0 },
                new int[] { 1, 0 },
                new int[] { 1, 2 },
                new int[] { 2, 1 },
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 2, 2 },
            });
            Assert.AreEqual("Draw", result);
        }

        [TestMethod]
        public void Tictactoe_4()
        {
            var solution = new _1275_FindWinnerOnATicTacToeGame();
            var result = solution.Tictactoe(new int[][] {
                new int[] { 0, 0 },
                new int[] { 1, 1 },
            });
            Assert.AreEqual("Pending", result);
        }
    }
}
