using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0419_BattleshipsInABoard_Test
    {
        [TestMethod]
        public void CountBattleships_1()
        {
            var solution = new _0419_BattleshipsInABoard();
            var result = solution.CountBattleships(new char[][] {
                new char[] { 'X', '.', '.', 'X' },
                new char[] { '.', '.', '.', 'X' },
                new char[] { '.', '.', '.', 'X' },
            });
            Assert.AreEqual(2, result);
        }
    }
}
