using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1504_CountSubmatricesWithAllOnes_Test
    {
        [TestMethod]
        public void NumSubmat_1()
        {
            var solution = new _1504_CountSubmatricesWithAllOnes();
            var result = solution.NumSubmat(new int[][] {
                new int[] { 1, 0, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 1, 1, 0 },
            });
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void NumSubmat_2()
        {
            var solution = new _1504_CountSubmatricesWithAllOnes();
            var result = solution.NumSubmat(new int[][] {
                new int[] { 0, 1, 1, 0 },
                new int[] { 0, 1, 1, 1 },
                new int[] { 1, 1, 1, 0 },
            });
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void NumSubmat_3()
        {
            var solution = new _1504_CountSubmatricesWithAllOnes();
            var result = solution.NumSubmat(new int[][] {
                new int[] { 1, 1, 1, 1, 1, 1 },
            });
            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void NumSubmat_4()
        {
            var solution = new _1504_CountSubmatricesWithAllOnes();
            var result = solution.NumSubmat(new int[][] {
                new int[] { 1, 0, 1 },
                new int[] { 0, 1, 0 },
                new int[] { 1, 0, 1 },
            });
            Assert.AreEqual(5, result);
        }
    }
}
