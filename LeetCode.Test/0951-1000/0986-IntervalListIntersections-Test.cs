using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0986_IntervalListIntersections_Test
    {
        [TestMethod]
        public void IntervalIntersection_1()
        {
            var solution = new _0986_IntervalListIntersections();
            var result = solution.IntervalIntersection(
                new int[][]
                {
                    new int[] { 0, 2 },
                    new int[] { 5, 10 },
                    new int[] { 13, 23 },
                    new int[] { 24, 25 },
                },
                new int[][]
                {
                    new int[] { 1, 5 },
                    new int[] { 8, 12 },
                    new int[] { 15, 24 },
                    new int[] { 25, 26 },
                });
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 1, 2 },
                    new int[] { 5, 5 },
                    new int[] { 8, 10 },
                    new int[] { 15, 23 },
                    new int[] { 24, 24 },
                    new int[] { 25, 25 },
                }, result);
        }
    }
}
