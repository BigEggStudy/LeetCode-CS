using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0201_BitwiseANDOfNumbersRange_Test
    {
        [TestMethod]
        public void RangeBitwiseAnd_1()
        {
            var solution = new _0201_BitwiseANDOfNumbersRange();
            var result = solution.RangeBitwiseAnd(5, 7);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void RangeBitwiseAnd_2()
        {
            var solution = new _0201_BitwiseANDOfNumbersRange();
            var result = solution.RangeBitwiseAnd(0, 1);
            Assert.AreEqual(0, result);
        }
    }
}
