using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1409_QueriesOnAPermutationWithKey_Test
    {
        [TestMethod]
        public void ProcessQueries_1()
        {
            var solution = new _1409_QueriesOnAPermutationWithKey();
            var result = solution.ProcessQueries(new int[] { 3, 1, 2, 1 }, 5);
            AssertHelper.AssertArray(new int[] { 2, 1, 2, 1 }, result);
        }

        [TestMethod]
        public void ProcessQueries_2()
        {
            var solution = new _1409_QueriesOnAPermutationWithKey();
            var result = solution.ProcessQueries(new int[] { 4, 1, 2, 2 }, 4);
            AssertHelper.AssertArray(new int[] { 3, 1, 2, 0 }, result);
        }

        [TestMethod]
        public void ProcessQueries_3()
        {
            var solution = new _1409_QueriesOnAPermutationWithKey();
            var result = solution.ProcessQueries(new int[] { 7, 5, 5, 8, 3 }, 8);
            AssertHelper.AssertArray(new int[] { 6, 5, 0, 7, 5 }, result);
        }
    }
}
