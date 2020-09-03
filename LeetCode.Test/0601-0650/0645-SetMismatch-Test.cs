using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0645_SetMismatch_Test
    {
        [TestMethod]
        public void FindErrorNums_1()
        {
            var solution = new _0645_SetMismatch();
            var result = solution.FindErrorNums(new int[] { 1, 2, 2, 4 });
            AssertHelper.AssertArray(new int[] { 2, 3 }, result);
        }
    }
}
