using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1317_ConvertIntegerToTheSumOfTwoNoZeroIntegers_Test
    {
        [TestMethod]
        public void GetNoZeroIntegers_1()
        {
            var solution = new _1317_ConvertIntegerToTheSumOfTwoNoZeroIntegers();
            var result = solution.GetNoZeroIntegers(2);
            AssertHelper.AssertArray(new int[] { 1, 1 }, result);
        }

        [TestMethod]
        public void GetNoZeroIntegers_2()
        {
            var solution = new _1317_ConvertIntegerToTheSumOfTwoNoZeroIntegers();
            var result = solution.GetNoZeroIntegers(11);
            AssertHelper.AssertArray(new int[] { 2, 9 }, result);
        }

        [TestMethod]
        public void GetNoZeroIntegers_3()
        {
            var solution = new _1317_ConvertIntegerToTheSumOfTwoNoZeroIntegers();
            var result = solution.GetNoZeroIntegers(10000);
            AssertHelper.AssertArray(new int[] { 1, 9999 }, result);
        }

        [TestMethod]
        public void GetNoZeroIntegers_4()
        {
            var solution = new _1317_ConvertIntegerToTheSumOfTwoNoZeroIntegers();
            var result = solution.GetNoZeroIntegers(69);
            AssertHelper.AssertArray(new int[] { 1, 68 }, result);
        }

        [TestMethod]
        public void GetNoZeroIntegers_5()
        {
            var solution = new _1317_ConvertIntegerToTheSumOfTwoNoZeroIntegers();
            var result = solution.GetNoZeroIntegers(1010);
            AssertHelper.AssertArray(new int[] { 11, 999 }, result);
        }
    }
}
