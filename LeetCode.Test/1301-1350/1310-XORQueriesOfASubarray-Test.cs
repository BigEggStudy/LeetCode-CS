using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1310_XORQueriesOfASubarray_Test
    {
        [TestMethod]
        public void XorQueries_1()
        {
            var solution = new _1310_XORQueriesOfASubarray();
            var result = solution.XorQueries(new int[] { 1, 3, 4, 8 }, new int[][] {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 0, 3 },
                new int[] { 3, 3 },
            });
            AssertHelper.AssertArray(new int[] { 2, 7, 14, 8 }, result);
        }

        [TestMethod]
        public void XorQueries_2()
        {
            var solution = new _1310_XORQueriesOfASubarray();
            var result = solution.XorQueries(new int[] { 4, 8, 2, 10 }, new int[][] {
                new int[] { 2, 3 },
                new int[] { 1, 3 },
                new int[] { 0, 0 },
                new int[] { 0, 3 },
            });
            AssertHelper.AssertArray(new int[] { 8, 0, 4, 4 }, result);
        }
    }
}
