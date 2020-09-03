using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _056_MergeIntervals_Test
    {
        [TestMethod]
        public void MergeTest()
        {
            var solution = new _056_MergeIntervals();
            var result = solution.Merge(new int[][] {
                new int[] { 1, 3 },
                new int[] { 2, 6 },
                new int[] { 8, 10 },
                new int[] { 15, 18 },
            });
            AssertHelper.AssertArray(new int[][] {
                new int[] { 1, 6 },
                new int[] { 8, 10 },
                new int[] { 15, 18 },
            }, result);
        }

        [TestMethod]
        public void MergeTest_NotOrdered()
        {
            var solution = new _056_MergeIntervals();
            var result = solution.Merge(new int[][] {
                new int[] { 1, 3 },
                new int[] { 0, 2 },
            });
            AssertHelper.AssertArray(new int[][] {
                new int[] { 0, 3 },
            }, result);
        }

        [TestMethod]
        public void MergeTest_2()
        {
            var solution = new _056_MergeIntervals();
            var result = solution.Merge(new int[][] {
                new int[] { 1, 4 },
                new int[] { 4, 5 },
            });
            AssertHelper.AssertArray(new int[][] {
                new int[] { 1, 5 },
            }, result);
        }

        [TestMethod]
        public void MergeTest_Empty()
        {
            var solution = new _056_MergeIntervals();
            var result = solution.Merge(new int[][] {
            });
            Assert.AreEqual(0, result.Length);
        }
    }
}
