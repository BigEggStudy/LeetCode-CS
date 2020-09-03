using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0368_LargestDivisibleSubset_Test
    {
        [TestMethod]
        public void LargestDivisibleSubset_1()
        {
            var solution = new _0368_LargestDivisibleSubset();
            var result = solution.LargestDivisibleSubset(new int[] { 1, 2, 3 });
            AssertHelper.AssertList(new int[] { 2, 1 }, result);
        }

        [TestMethod]
        public void LargestDivisibleSubset_2()
        {
            var solution = new _0368_LargestDivisibleSubset();
            var result = solution.LargestDivisibleSubset(new int[] { 1, 2, 4, 8 });
            AssertHelper.AssertList(new int[] { 8, 4, 2, 1 }, result);
        }
    }
}
