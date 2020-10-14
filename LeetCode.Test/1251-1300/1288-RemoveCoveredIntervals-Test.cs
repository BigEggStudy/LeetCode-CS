using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1288_RemoveCoveredIntervals_Test
    {
        [TestMethod]
        public void RemoveCoveredIntervals_1()
        {
            var solution = new _1288_RemoveCoveredIntervals();
            var result = solution.RemoveCoveredIntervals(new int[][] {
                new int[] { 1, 4 },
                new int[] { 3, 6 },
                new int[] { 2, 8 },
            });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void RemoveCoveredIntervals_2()
        {
            var solution = new _1288_RemoveCoveredIntervals();
            var result = solution.RemoveCoveredIntervals(new int[][] {
                new int[] { 1, 4 },
                new int[] { 2, 3 },
            });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void RemoveCoveredIntervals_3()
        {
            var solution = new _1288_RemoveCoveredIntervals();
            var result = solution.RemoveCoveredIntervals(new int[][] {
                new int[] { 0, 10 },
                new int[] { 5, 12 },
            });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void RemoveCoveredIntervals_4()
        {
            var solution = new _1288_RemoveCoveredIntervals();
            var result = solution.RemoveCoveredIntervals(new int[][] {
                new int[] { 3, 10 },
                new int[] { 4, 10 },
                new int[] { 5, 11 },
            });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void RemoveCoveredIntervals_5()
        {
            var solution = new _1288_RemoveCoveredIntervals();
            var result = solution.RemoveCoveredIntervals(new int[][] {
                new int[] { 1, 2 },
                new int[] { 1, 4 },
                new int[] { 3, 4 },
            });
            Assert.AreEqual(1, result);
        }
    }
}
