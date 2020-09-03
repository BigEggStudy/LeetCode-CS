using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0918_MaximumSumCircularSubarray_Test
    {
        [TestMethod]
        public void MaxSubarraySumCircular_1()
        {
            var solution = new _0918_MaximumSumCircularSubarray();
            var result = solution.MaxSubarraySumCircular(new int[] { 1, -2, 3, -2 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MaxSubarraySumCircular_2()
        {
            var solution = new _0918_MaximumSumCircularSubarray();
            var result = solution.MaxSubarraySumCircular(new int[] { 5, -3, 5 });
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void MaxSubarraySumCircular_3()
        {
            var solution = new _0918_MaximumSumCircularSubarray();
            var result = solution.MaxSubarraySumCircular(new int[] { 3, -1, 2, -1 });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MaxSubarraySumCircular_4()
        {
            var solution = new _0918_MaximumSumCircularSubarray();
            var result = solution.MaxSubarraySumCircular(new int[] { 3, -2, 2, -3 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MaxSubarraySumCircular_5()
        {
            var solution = new _0918_MaximumSumCircularSubarray();
            var result = solution.MaxSubarraySumCircular(new int[] { -2, -3, -1 });
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void MaxSubarraySumCircular_6()
        {
            var solution = new _0918_MaximumSumCircularSubarray();
            var result = solution.MaxSubarraySumCircular(new int[] { 3, -1, 2, -10, 2, -1, 3 });
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void MaxSubarraySumCircular_7()
        {
            var solution = new _0918_MaximumSumCircularSubarray();
            var result = solution.MaxSubarraySumCircular(new int[] { -2 });
            Assert.AreEqual(-2, result);
        }
    }
}
