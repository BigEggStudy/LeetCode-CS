using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0215_KthLargestElementInAnArray_Test
    {
        [TestMethod]
        public void FindKthLargestTest_1()
        {
            var solution = new _0215_KthLargestElementInAnArray();
            var result = solution.FindKthLargest(new int[] { 3, 2, 1, 5, 6, 4 }, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void FindKthLargestTest_2()
        {
            var solution = new _0215_KthLargestElementInAnArray();
            var result = solution.FindKthLargest(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void FindKthLargestTest_3()
        {
            var solution = new _0215_KthLargestElementInAnArray();
            var result = solution.FindKthLargest(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void FindKthLargestTest_4()
        {
            var solution = new _0215_KthLargestElementInAnArray();
            var result = solution.FindKthLargest(new int[] { -1, 2, 0 }, 3);
            Assert.AreEqual(-1, result);
        }
    }
}
