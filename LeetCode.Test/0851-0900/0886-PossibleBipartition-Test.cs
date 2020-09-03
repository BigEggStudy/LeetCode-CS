using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0886_PossibleBipartition_Test
    {
        [TestMethod]
        public void PossibleBipartition_1()
        {
            var solution = new _0886_PossibleBipartition();
            var result = solution.PossibleBipartition(4, new int[][] {
                new int[] { 1, 2 },
                new int[] { 1, 3 },
                new int[] { 2, 4 },
            });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PossibleBipartition_2()
        {
            var solution = new _0886_PossibleBipartition();
            var result = solution.PossibleBipartition(3, new int[][] {
                new int[] { 1, 2 },
                new int[] { 1, 3 },
                new int[] { 2, 3 },
            });
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PossibleBipartition_3()
        {
            var solution = new _0886_PossibleBipartition();
            var result = solution.PossibleBipartition(5, new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 4, 5 },
                new int[] { 1, 5 },
            });
            Assert.IsFalse(result);
        }
    }
}
