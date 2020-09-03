using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0190_ReverseBits_Test
    {
        [TestMethod]
        public void reverseBits_1()
        {
            var solution = new _0190_ReverseBits();
            var result = solution.reverseBits((uint)43261596);
            Assert.AreEqual((uint)964176192, result);
        }

        [TestMethod]
        public void reverseBits_2()
        {
            var solution = new _0190_ReverseBits();
            var result = solution.reverseBits((uint)4294967293);
            Assert.AreEqual((uint)3221225471, result);
        }
    }
}
