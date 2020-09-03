using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0766_ToeplitzMatrix_Test
    {
        [TestMethod]
        public void IsToeplitzMatrix_1()
        {
            var solution = new _0766_ToeplitzMatrix();
            var result = solution.IsToeplitzMatrix(new int[][] {
                new int[] { 1, 2, 3, 4 },
                new int[] { 5, 1, 2, 3 },
                new int[] { 9, 5, 1, 2 },
            });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsToeplitzMatrix_2()
        {
            var solution = new _0766_ToeplitzMatrix();
            var result = solution.IsToeplitzMatrix(new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 2 }
            });
            Assert.IsFalse(result);
        }
    }
}
