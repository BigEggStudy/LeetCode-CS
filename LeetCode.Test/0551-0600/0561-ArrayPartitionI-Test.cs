using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0561_ArrayPartitionI_Test
    {
        [TestMethod]
        public void ArrayPairSum_1()
        {
            var solution = new _0561_ArrayPartitionI();
            var result = solution.ArrayPairSum(new int[] { 1, 4, 3, 2 });
            Assert.AreEqual(4, result);
        }
    }
}
