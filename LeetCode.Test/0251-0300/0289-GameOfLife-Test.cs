using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0289_GameOfLife_Test
    {
        [TestMethod]
        public void GameOfLifeTest()
        {
            var input = new int[][]
            {
                new int[] { 0, 1, 0 },
                new int[] { 0, 0, 1 },
                new int[] { 1, 1, 1 },
                new int[] { 0, 0, 0 }
            };


            var solution = new _0289_GameOfLife();
            solution.GameOfLife(input);
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 0, 0, 0 },
                    new int[] { 1, 0, 1 },
                    new int[] { 0, 1, 1 },
                    new int[] { 0, 1, 0 }
                },
                input);
        }
    }
}
