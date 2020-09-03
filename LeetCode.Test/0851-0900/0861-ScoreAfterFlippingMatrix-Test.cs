using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0861_ScoreAfterFlippingMatrix_Test
    {
        [TestMethod]
        public void MatrixScore_1()
        {
            var solution = new _0861_ScoreAfterFlippingMatrix();
            var result = solution.MatrixScore(new int[][] {
                new int[] { 0, 0, 1, 1 },
                new int[] { 1, 0, 1, 0 },
                new int[] { 1, 1, 0, 0 }
            });
            Assert.AreEqual(39, result);
        }
    }
}
