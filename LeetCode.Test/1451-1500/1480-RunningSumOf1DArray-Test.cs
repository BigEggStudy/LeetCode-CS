using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1480_RunningSumOf1DArray_Test
    {
        [TestMethod]
        public void RunningSum_1()
        {
            var solution = new _1480_RunningSumOf1DArray();
            var result = solution.RunningSum(new int[] { 1, 2, 3, 4 });
            AssertHelper.AssertArray(new int[] { 1, 3, 6, 10 }, result);
        }

        [TestMethod]
        public void RunningSum_2()
        {
            var solution = new _1480_RunningSumOf1DArray();
            var result = solution.RunningSum(new int[] { 1, 1, 1, 1, 1 });
            AssertHelper.AssertArray(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void RunningSum_3()
        {
            var solution = new _1480_RunningSumOf1DArray();
            var result = solution.RunningSum(new int[] { 3, 1, 2, 10, 1 });
            AssertHelper.AssertArray(new int[] { 3, 4, 6, 16, 17 }, result);
        }
    }
}
