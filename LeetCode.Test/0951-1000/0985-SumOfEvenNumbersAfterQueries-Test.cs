using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0985_SumOfEvenNumbersAfterQueries_Test
    {
        [TestMethod]
        public void SumEvenAfterQueries_1()
        {
            var solution = new _0985_SumOfEvenNumbersAfterQueries();
            var result = solution.SumEvenAfterQueries(new int[] { 1, 2, 3, 4 }, new int[][] {
                new int[] { 1, 0 },
                new int[] { -3, 1 },
                new int[] { -4, 0 },
                new int[] { 2, 3 },
            });
            AssertHelper.AssertArray(new int[] { 8, 6, 2, 4 }, result);
        }
    }
}
