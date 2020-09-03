using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1085_SumOfDigitsInTheMinimumNumber_Test
    {
        [TestMethod]
        public void SumOfDigits_1()
        {
            var solution = new _1085_SumOfDigitsInTheMinimumNumber();
            var result = solution.SumOfDigits(new int[] { 34, 23, 1, 24, 75, 33, 54, 8 });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SumOfDigits_2()
        {
            var solution = new _1085_SumOfDigitsInTheMinimumNumber();
            var result = solution.SumOfDigits(new int[] { 99, 77, 33, 66, 55 });
            Assert.AreEqual(1, result);
        }
    }
}
