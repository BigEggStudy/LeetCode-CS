using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1403_MinimumSubsequenceInNonIncreasingOrder_Test
    {
        [TestMethod]
        public void MinSubsequence_1()
        {
            var solution = new _1403_MinimumSubsequenceInNonIncreasingOrder();
            var result = solution.MinSubsequence(new int[] { 4, 3, 10, 9, 8 });
            AssertHelper.AssertList(new int[] { 10, 9 }, result);
        }

        [TestMethod]
        public void MinSubsequence_2()
        {
            var solution = new _1403_MinimumSubsequenceInNonIncreasingOrder();
            var result = solution.MinSubsequence(new int[] { 4, 4, 7, 6, 7 });
            AssertHelper.AssertList(new int[] { 7, 7, 6 }, result);
        }
    }
}
