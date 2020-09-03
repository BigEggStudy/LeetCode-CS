using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0303_RangeSumQueryImmutable_Test
    {
        [TestMethod]
        public void RangeSumQueryImmutable_1()
        {
            var solution = new _0303_RangeSumQueryImmutable(new int[] { -2, 0, 3, -5, 2, -1 });
            Assert.AreEqual(1, solution.SumRange(0, 2));
            Assert.AreEqual(-1, solution.SumRange(2, 5));
            Assert.AreEqual(-3, solution.SumRange(0, 5));
        }
    }
}
