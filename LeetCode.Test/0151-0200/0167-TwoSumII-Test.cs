using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0167_TwoSumII_Test
    {
        [TestMethod]
        public void TwoSumTest_1()
        {
            var solution = new _0167_TwoSumII();
            var result = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            AssertHelper.AssertArray(new int[] { 1, 2 }, result);
        }

        [TestMethod]
        public void TwoSumTest_2()
        {
            var solution = new _0167_TwoSumII();
            var result = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 10);
            AssertHelper.AssertArray(new int[] { }, result);
        }
    }
}
