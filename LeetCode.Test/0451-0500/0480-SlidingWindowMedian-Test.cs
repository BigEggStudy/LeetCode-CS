using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0480_SlidingWindowMedian_Test
    {
        [TestMethod]
        public void MedianSlidingWindow_1()
        {
            var solution = new _0480_SlidingWindowMedian();
            var result = solution.MedianSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
            AssertHelper.AssertArray(new double[] { 1, -1, -1, 3, 5, 6 }, result);
        }

        [TestMethod]
        public void MedianSlidingWindow_2()
        {
            var solution = new _0480_SlidingWindowMedian();
            var result = solution.MedianSlidingWindow(new int[] { 2147483647, 2147483647 }, 2);
            AssertHelper.AssertArray(new double[] { 2147483647 }, result);
        }

        [TestMethod]
        public void MedianSlidingWindow_3()
        {
            var solution = new _0480_SlidingWindowMedian();
            var result = solution.MedianSlidingWindow(new int[] { 5, 2, 2, 7, 3, 7, 9, 0, 2, 3 }, 9);
            AssertHelper.AssertArray(new double[] { 3, 3 }, result);
        }
    }
}
