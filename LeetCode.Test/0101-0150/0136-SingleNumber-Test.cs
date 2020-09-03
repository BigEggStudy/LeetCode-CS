using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0136_SingleNumber_Test
    {
        [TestMethod]
        public void SingleNumberTest_1()
        {
            var solution = new _0136_SingleNumber();
            var result = solution.SingleNumber(new int[] { 2, 2, 1 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SingleNumberTest_2()
        {
            var solution = new _0136_SingleNumber();
            var result = solution.SingleNumber(new int[] { 4, 1, 2, 1, 2 });
            Assert.AreEqual(4, result);
        }
    }
}
