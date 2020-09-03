using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1013_PartitionArrayIntoThreePartsWithEqualSum_Test
    {
        [TestMethod]
        public void CanThreePartsEqualSum_1()
        {
            var solution = new _1013_PartitionArrayIntoThreePartsWithEqualSum();
            var result = solution.CanThreePartsEqualSum(new int[] { 0, 2, 1, -6, 6, -7, 9, 1, 2, 0, 1 });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanThreePartsEqualSum_2()
        {
            var solution = new _1013_PartitionArrayIntoThreePartsWithEqualSum();
            var result = solution.CanThreePartsEqualSum(new int[] { 0, 2, 1, -6, 6, 7, 9, -1, 2, 0, 1 });
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void CanThreePartsEqualSum_3()
        {
            var solution = new _1013_PartitionArrayIntoThreePartsWithEqualSum();
            var result = solution.CanThreePartsEqualSum(new int[] { 3, 3, 6, 5, -2, 2, 5, 1, -9, 4 });
            Assert.IsTrue(result);
        }
    }
}
