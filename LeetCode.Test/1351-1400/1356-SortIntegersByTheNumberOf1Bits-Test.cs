using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1356_SortIntegersByTheNumberOf1Bits_Test
    {
        [TestMethod]
        public void SortByBits_1()
        {
            var solution = new _1356_SortIntegersByTheNumberOf1Bits();
            var result = solution.SortByBits(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
            AssertHelper.AssertArray(new int[] { 0, 1, 2, 4, 8, 3, 5, 6, 7 }, result);
        }

        [TestMethod]
        public void SortByBits_2()
        {
            var solution = new _1356_SortIntegersByTheNumberOf1Bits();
            var result = solution.SortByBits(new int[] { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 });
            AssertHelper.AssertArray(new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 }, result);
        }

        [TestMethod]
        public void SortByBits_3()
        {
            var solution = new _1356_SortIntegersByTheNumberOf1Bits();
            var result = solution.SortByBits(new int[] { 10000, 10000 });
            AssertHelper.AssertArray(new int[] { 10000, 10000 }, result);
        }

        [TestMethod]
        public void SortByBits_4()
        {
            var solution = new _1356_SortIntegersByTheNumberOf1Bits();
            var result = solution.SortByBits(new int[] { 2, 3, 5, 7, 11, 13, 17, 19 });
            AssertHelper.AssertArray(new int[] { 2, 3, 5, 17, 7, 11, 13, 19 }, result);
        }

        [TestMethod]
        public void SortByBits_5()
        {
            var solution = new _1356_SortIntegersByTheNumberOf1Bits();
            var result = solution.SortByBits(new int[] { 10, 100, 1000, 10000 });
            AssertHelper.AssertArray(new int[] { 10, 100, 10000, 1000 }, result);
        }
    }
}
