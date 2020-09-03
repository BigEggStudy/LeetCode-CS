using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0338_CountingBits_Test
    {
        [TestMethod]
        public void CountBits_1()
        {
            var solution = new _0338_CountingBits();
            var result = solution.CountBits(2);
            AssertHelper.AssertArray(new int[] { 0, 1, 1 }, result);
        }

        [TestMethod]
        public void CountBits_2()
        {
            var solution = new _0338_CountingBits();
            var result = solution.CountBits(5);
            AssertHelper.AssertArray(new int[] { 0, 1, 1, 2, 1, 2 }, result);
        }
    }
}
