using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1365_HowManyNumbersAreSmallerThanTheCurrentNumber_Test
    {
        [TestMethod]
        public void SmallerNumbersThanCurrent_1()
        {
            var solution = new _1365_HowManyNumbersAreSmallerThanTheCurrentNumber();
            var result = solution.SmallerNumbersThanCurrent(new int[] { 8, 1, 2, 2, 3 });
            AssertHelper.AssertArray(new int[] { 4, 0, 1, 1, 3 }, result);
        }

        [TestMethod]
        public void SmallerNumbersThanCurrent_2()
        {
            var solution = new _1365_HowManyNumbersAreSmallerThanTheCurrentNumber();
            var result = solution.SmallerNumbersThanCurrent(new int[] { 6, 5, 4, 8 });
            AssertHelper.AssertArray(new int[] { 2, 1, 0, 3 }, result);
        }

        [TestMethod]
        public void SmallerNumbersThanCurrent_3()
        {
            var solution = new _1365_HowManyNumbersAreSmallerThanTheCurrentNumber();
            var result = solution.SmallerNumbersThanCurrent(new int[] { 7, 7, 7, 7 });
            AssertHelper.AssertArray(new int[] { 0, 0, 0, 0 }, result);
        }

        [TestMethod]
        public void SmallerNumbersThanCurrent_4()
        {
            var solution = new _1365_HowManyNumbersAreSmallerThanTheCurrentNumber();
            var result = solution.SmallerNumbersThanCurrent(new int[] { 5, 0, 10, 0, 10, 6 });
            AssertHelper.AssertArray(new int[] { 2, 0, 4, 0, 4, 3 }, result);
        }
    }
}
