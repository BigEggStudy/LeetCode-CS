using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0566_ReshapeTheMatrix_Test
    {
        [TestMethod]
        public void MatrixReshape_1()
        {
            var solution = new _0566_ReshapeTheMatrix();
            var result = solution.MatrixReshape(new int[][]
                {
                    new int[] { 1, 2 },
                    new int[] { 3, 4 },
                }, 1, 4);
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 1, 2, 3, 4 }
                }, result);
        }

        [TestMethod]
        public void MatrixReshape_2()
        {
            var solution = new _0566_ReshapeTheMatrix();
            var result = solution.MatrixReshape(new int[][]
                {
                    new int[] { 1, 2 },
                    new int[] { 3, 4 },
                }, 2, 4);
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 1, 2 },
                    new int[] { 3, 4 },
                }, result);
        }
    }
}
