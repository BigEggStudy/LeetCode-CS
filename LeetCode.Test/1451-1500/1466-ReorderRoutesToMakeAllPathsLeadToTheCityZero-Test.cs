using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1466_ReorderRoutesToMakeAllPathsLeadToTheCityZero_Test
    {
        [TestMethod]
        public void MinReorder_1()
        {
            var solution = new _1466_ReorderRoutesToMakeAllPathsLeadToTheCityZero();
            var result = solution.MinReorder(6, new int[][] {
                new int[] { 0, 1 },
                new int[] { 1, 3 },
                new int[] { 2, 3 },
                new int[] { 4, 0 },
                new int[] { 4, 5 },
            });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MinReorder_2()
        {
            var solution = new _1466_ReorderRoutesToMakeAllPathsLeadToTheCityZero();
            var result = solution.MinReorder(5, new int[][] {
                new int[] { 1, 0 },
                new int[] { 1, 2 },
                new int[] { 3, 2 },
                new int[] { 3, 4 },
            });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MinReorder_3()
        {
            var solution = new _1466_ReorderRoutesToMakeAllPathsLeadToTheCityZero();
            var result = solution.MinReorder(3, new int[][] {
                new int[] { 1, 0 },
                new int[] { 2, 0 },
            });
            Assert.AreEqual(0, result);
        }
    }
}
