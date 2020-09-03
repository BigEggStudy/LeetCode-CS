using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1314_MatrixBlockSum_Test
    {
        [TestMethod]
        public void MatrixBlockSum_1()
        {
            var solution = new _1314_MatrixBlockSum();
            var result = solution.MatrixBlockSum(new int[][]
                {
                    new int[] { 1, 2, 3 },
                    new int[] { 4, 5, 6 },
                    new int[] { 7, 8, 9 },
                }, 1);
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 12, 21, 16 },
                    new int[] { 27, 45, 33 },
                    new int[] { 24, 39, 28 },
                }, result);
        }

        [TestMethod]
        public void MatrixBlockSum_2()
        {
            var solution = new _1314_MatrixBlockSum();
            var result = solution.MatrixBlockSum(
                new int[][]
                {
                    new int[] { 1, 2, 3 },
                    new int[] { 4, 5, 6 },
                    new int[] { 7, 8, 9 },
                }, 2);
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 45, 45, 45 },
                    new int[] { 45, 45, 45 },
                    new int[] { 45, 45, 45 },
                }, result);
        }

        [TestMethod]
        public void MatrixBlockSum_3()
        {
            var solution = new _1314_MatrixBlockSum();
            var result = solution.MatrixBlockSum(
                new int[][]
                {
                    new int[] { 67, 64, 78 },
                    new int[] { 99, 98, 38 },
                    new int[] { 82, 46, 46 },
                    new int[] {  6, 52, 55 },
                    new int[] { 55, 99, 45 },
                }, 3);
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 731, 731, 731},
                    new int[] { 930, 930, 930 },
                    new int[] { 930, 930, 930 },
                    new int[] { 930, 930, 930 },
                    new int[] { 721, 721, 721 },
                }, result);
        }
    }
}
