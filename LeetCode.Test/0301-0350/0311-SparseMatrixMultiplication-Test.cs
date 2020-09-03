using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0311_SparseMatrixMultiplication_Test
    {
        [TestMethod]
        public void Multiply_1()
        {
            var solution = new _0311_SparseMatrixMultiplication();
            var result = solution.Multiply(new int[][] {
                new int[] {  1, 0, 0 },
                new int[] { -1, 0, 3 },
            }, new int[][] {
                new int[] { 7, 0, 0 },
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 1 },
            });
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] {  7, 0, 0 },
                    new int[] { -7, 0, 3 },
                }, result);
        }
    }
}
