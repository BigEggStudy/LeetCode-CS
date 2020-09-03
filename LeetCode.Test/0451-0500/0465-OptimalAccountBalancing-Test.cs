using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0465_OptimalAccountBalancing_Test
    {
        [TestMethod]
        public void MinTransfers_1()
        {
            var solution = new _0465_OptimalAccountBalancing();
            var result = solution.MinTransfers(
                new int[][] {
                    new int[] { 0, 1, 10 },
                    new int[] { 2, 0, 5 }
                }
            );
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MinTransfers_2()
        {
            var solution = new _0465_OptimalAccountBalancing();
            var result = solution.MinTransfers(
                new int[][] {
                    new int[] { 0, 1, 10 },
                    new int[] { 1, 0, 1 },
                    new int[] { 1, 2, 5 },
                    new int[] { 2, 0, 5 },
                }
            );
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MinTransfers_3()
        {
            var solution = new _0465_OptimalAccountBalancing();
            var result = solution.MinTransfers(
                new int[][] {
                    new int[] { 1, 5, 8 },
                    new int[] { 8, 9, 8 },
                    new int[] { 2, 3, 9 },
                    new int[] { 4, 3, 1 },
                }
            );
            Assert.AreEqual(4, result);
        }
    }
}
