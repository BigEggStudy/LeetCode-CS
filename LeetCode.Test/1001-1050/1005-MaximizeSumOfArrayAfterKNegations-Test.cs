using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1005_MaximizeSumOfArrayAfterKNegations_Test
    {
        [TestMethod]
        public void LargestSumAfterKNegations_1()
        {
            var solution = new _1005_MaximizeSumOfArrayAfterKNegations();
            var result = solution.LargestSumAfterKNegations(new int[] { 4, 2, 3 }, 1);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void LargestSumAfterKNegations_2()
        {
            var solution = new _1005_MaximizeSumOfArrayAfterKNegations();
            var result = solution.LargestSumAfterKNegations(new int[] { 3, -1, 0, 2 }, 3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void LargestSumAfterKNegations_3()
        {
            var solution = new _1005_MaximizeSumOfArrayAfterKNegations();
            var result = solution.LargestSumAfterKNegations(new int[] { 2, -3, -1, 5, -4 }, 2);
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void LargestSumAfterKNegations_4()
        {
            var solution = new _1005_MaximizeSumOfArrayAfterKNegations();
            var result = solution.LargestSumAfterKNegations(new int[] { -2, 9, 9, 8, 4 }, 5);
            Assert.AreEqual(32, result);
        }
    }
}
