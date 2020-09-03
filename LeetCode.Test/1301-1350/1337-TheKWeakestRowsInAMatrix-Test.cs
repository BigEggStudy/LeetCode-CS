using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1337_TheKWeakestRowsInAMatrix_Test
    {
        [TestMethod]
        public void KWeakestRows_1()
        {
            var solution = new _1337_TheKWeakestRowsInAMatrix();
            var result = solution.KWeakestRows(new int[][] {
                new int[] { 1, 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 1 },
            }, 3);
            AssertHelper.AssertArray(new int[] { 2, 0, 3 }, result);
        }

        [TestMethod]
        public void KWeakestRows_2()
        {
            var solution = new _1337_TheKWeakestRowsInAMatrix();
            var result = solution.KWeakestRows(new int[][] {
                new int[] { 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0 },
                new int[] { 1, 0, 0, 0 },
            }, 2);
            AssertHelper.AssertArray(new int[] { 0, 2 }, result);
        }
    }
}
