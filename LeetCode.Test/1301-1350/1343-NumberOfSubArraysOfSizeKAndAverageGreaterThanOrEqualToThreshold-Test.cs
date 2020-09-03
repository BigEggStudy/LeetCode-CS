using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1343_NumberOfSubArraysOfSizeKAndAverageGreaterThanOrEqualToThreshold_Test
    {
        [TestMethod]
        public void NumOfSubarrays_1()
        {
            var solution = new _1343_NumberOfSubArraysOfSizeKAndAverageGreaterThanOrEqualToThreshold();
            var result = solution.NumOfSubarrays(new int[] { 2, 2, 2, 2, 5, 5, 5, 8 }, 3, 4);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NumOfSubarrays_2()
        {
            var solution = new _1343_NumberOfSubArraysOfSizeKAndAverageGreaterThanOrEqualToThreshold();
            var result = solution.NumOfSubarrays(new int[] { 1, 1, 1, 1, 1 }, 1, 0);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void NumOfSubarrays_3()
        {
            var solution = new _1343_NumberOfSubArraysOfSizeKAndAverageGreaterThanOrEqualToThreshold();
            var result = solution.NumOfSubarrays(new int[] { 11, 13, 17, 23, 29, 31, 7, 5, 2, 3 }, 3, 5);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void NumOfSubarrays_4()
        {
            var solution = new _1343_NumberOfSubArraysOfSizeKAndAverageGreaterThanOrEqualToThreshold();
            var result = solution.NumOfSubarrays(new int[] { 7, 7, 7, 7, 7, 7, 7 }, 7, 7);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void NumOfSubarrays_5()
        {
            var solution = new _1343_NumberOfSubArraysOfSizeKAndAverageGreaterThanOrEqualToThreshold();
            var result = solution.NumOfSubarrays(new int[] { 4, 4, 4, 4 }, 4, 1);
            Assert.AreEqual(1, result);
        }
    }
}
