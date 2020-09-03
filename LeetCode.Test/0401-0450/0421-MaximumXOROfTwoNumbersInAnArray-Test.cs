using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0421_MaximumXOROfTwoNumbersInAnArray_Test
    {
        [TestMethod]
        public void FindMaximumXORTest()
        {
            var solution = new _0421_MaximumXOROfTwoNumbersInAnArray();
            var result = solution.FindMaximumXOR(new int[] { 3, 10, 5, 25, 2, 8 });
            Assert.AreEqual(28, result);
        }
    }
}
