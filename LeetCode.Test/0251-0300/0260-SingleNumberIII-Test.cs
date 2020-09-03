using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0260_SingleNumberIII_Test
    {
        [TestMethod]
        public void SingleNumber_1()
        {
            var solution = new _0260_SingleNumberIII();
            var result = solution.SingleNumber(new int[] { 1, 2, 1, 3, 2, 5 });
            AssertHelper.AssertArray(new int[] { 3, 5 }, result);
        }
    }
}
