using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0137_SingleNumberII_Test
    {
        [TestMethod]
        public void SingleNumber_1()
        {
            var solution = new _0137_SingleNumberII();
            var result = solution.SingleNumber(new int[] { 2, 2, 3, 2 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SingleNumber_2()
        {
            var solution = new _0137_SingleNumberII();
            var result = solution.SingleNumber(new int[] { 0, 1, 0, 1, 0, 1, 99 });
            Assert.AreEqual(99, result);
        }
    }
}
