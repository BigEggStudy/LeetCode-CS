using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _084_LargestRectangleInHistogram_Test
    {
        [TestMethod]
        public void LargestRectangleAreaTest()
        {
            var input = new int[] { 2, 1, 5, 6, 2, 3 };

            var solution = new _084_LargestRectangleInHistogram();
            var result = solution.LargestRectangleArea(input);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void LargestRectangleAreaTest_Ordered()
        {
            var input = new int[] { 1, 2, 3, 4, 5, 6 };

            var solution = new _084_LargestRectangleInHistogram();
            var result = solution.LargestRectangleArea(input);

            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void LargestRectangleAreaTest_ReverseOrdered()
        {
            var input = new int[] { 6, 5, 4, 3, 2, 1 };

            var solution = new _084_LargestRectangleInHistogram();
            var result = solution.LargestRectangleArea(input);

            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void LargestRectangleAreaTest_AllTheSame()
        {
            var input = new int[] { 3, 3, 3, 3, 3, 3 };

            var solution = new _084_LargestRectangleInHistogram();
            var result = solution.LargestRectangleArea(input);

            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void LargestRectangleAreaTest_2()
        {
            var input = new int[] { 1, 2, 2 };

            var solution = new _084_LargestRectangleInHistogram();
            var result = solution.LargestRectangleArea(input);

            Assert.AreEqual(4, result);
        }
    }
}
