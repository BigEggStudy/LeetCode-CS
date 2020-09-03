using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0174_DungeonGame_Test
    {
        [TestMethod]
        public void CalculateMinimumHP_1()
        {
            var solution = new _0174_DungeonGame();
            var result = solution.CalculateMinimumHP(new int[][] {
                new int[] { -2, -3, 3 },
                new int[] { -5, -10, 1 },
                new int[] { 10, 30, -5 },
            });
            Assert.AreEqual(7, result);
        }
    }
}
