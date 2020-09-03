using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0762_PrimeNumberOfSetBitsInBinaryRepresentation_Test
    {
        [TestMethod]
        public void CountPrimeSetBits_1()
        {
            var solution = new _0762_PrimeNumberOfSetBitsInBinaryRepresentation();
            var result = solution.CountPrimeSetBits(6, 10);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void CountPrimeSetBits_2()
        {
            var solution = new _0762_PrimeNumberOfSetBitsInBinaryRepresentation();
            var result = solution.CountPrimeSetBits(10, 15);
            Assert.AreEqual(5, result);
        }
    }
}
