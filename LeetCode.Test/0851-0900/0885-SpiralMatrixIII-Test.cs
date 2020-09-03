using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0885_SpiralMatrixIII_Test
    {
        [TestMethod]
        public void SpiralMatrixIII_1()
        {
            var solution = new _0885_SpiralMatrixIII();
            var result = solution.SpiralMatrixIII(1, 4, 0, 0);
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 0, 0 },
                    new int[] { 0, 1 },
                    new int[] { 0, 2 },
                    new int[] { 0, 3 },
                }, result);
        }

        [TestMethod]
        public void SpiralMatrixIII_2()
        {
            var solution = new _0885_SpiralMatrixIII();
            var result = solution.SpiralMatrixIII(5, 6, 1, 4);
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 1, 4 },
                    new int[] { 1, 5 },
                    new int[] { 2, 5 },
                    new int[] { 2, 4 },
                    new int[] { 2, 3 },
                    new int[] { 1, 3 },
                    new int[] { 0, 3 },
                    new int[] { 0, 4 },
                    new int[] { 0, 5 },
                    new int[] { 3, 5 },
                    new int[] { 3, 4 },
                    new int[] { 3, 3 },
                    new int[] { 3, 2 },
                    new int[] { 2, 2 },
                    new int[] { 1, 2 },
                    new int[] { 0, 2 },
                    new int[] { 4, 5 },
                    new int[] { 4, 4 },
                    new int[] { 4, 3 },
                    new int[] { 4, 2 },
                    new int[] { 4, 1 },
                    new int[] { 3, 1 },
                    new int[] { 2, 1 },
                    new int[] { 1, 1 },
                    new int[] { 0, 1 },
                    new int[] { 4, 0 },
                    new int[] { 3, 0 },
                    new int[] { 2, 0 },
                    new int[] { 1, 0 },
                    new int[] { 0, 0 },
                }, result);
        }
}
}
