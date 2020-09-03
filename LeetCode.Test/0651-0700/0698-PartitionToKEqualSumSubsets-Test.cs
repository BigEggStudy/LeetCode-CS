using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0698_PartitionToKEqualSumSubsets_Test
    {
        [TestMethod]
        public void CanPartitionKSubsets_1()
        {
            var solution = new _0698_PartitionToKEqualSumSubsets();
            var result = solution.CanPartitionKSubsets(new int[] { 4, 3, 2, 3, 5, 2, 1 }, 4);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanPartitionKSubsets_2()
        {
            var solution = new _0698_PartitionToKEqualSumSubsets();
            var result = solution.CanPartitionKSubsets(new int[] { 4, 3, 2, 3, 5, 2, 1, 1 }, 4);
            Assert.IsFalse(result);
        }
    }
}
