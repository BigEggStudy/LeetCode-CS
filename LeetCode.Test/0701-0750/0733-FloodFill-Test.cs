using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0733_FloodFill_Test
    {
        [TestMethod]
        public void FloodFill_1()
        {
            var solution = new _0733_FloodFill();
            var result = solution.FloodFill(new int[][]
                {
                    new int[] { 1, 1, 1 },
                    new int[] { 1, 1, 0 },
                    new int[] { 1, 0, 1 },
                }, 1, 1, 2);
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 2, 2, 2 },
                    new int[] { 2, 2, 0 },
                    new int[] { 2, 0, 1 },
                }, result);
        }
    }
}
