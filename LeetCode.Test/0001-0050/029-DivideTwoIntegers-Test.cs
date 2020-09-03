using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.Test
{
    [TestClass]
    public class _029_DivideTwoIntegers_Test
    {
        [TestMethod]
        public void DivideTest()
        {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(5, 2);
            Assert.AreEqual(2, result);

            result = solution.Divide(-5, 2);
            Assert.AreEqual(-2, result);

            result = solution.Divide(5, -2);
            Assert.AreEqual(-2, result);

            result = solution.Divide(-5, -2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideTest_DivisorEqualZero()
        {
            var solution = new _029_DivideTwoIntegers();
            solution.Divide(5, 0);
        }

        [TestMethod]
        public void DivideTest_MaxValueDivideMaxValue()
        {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MaxValue, int.MaxValue);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void DivideTest_MinValueDivideMinValue()
        {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MinValue, int.MinValue);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void DivideTest_DivisorLargerThanDividend()
        {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(5, 10);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [Timeout(100)]
        public void DivideTest_MinValueDivideMinusOne()
        {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MinValue, -1);

            Assert.AreEqual(int.MaxValue, result);
        }

        [TestMethod]
        [Timeout(100)]
        public void DivideTest_MinValueDivideOne()
        {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MinValue, 1);

            Assert.AreEqual(int.MinValue, result);
        }

        [TestMethod]
        [Timeout(100)]
        public void DivideTest_MaxValueDivideMinusOne()
        {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MaxValue, -1);

            Assert.AreEqual(int.MinValue + 1, result);
        }

        [TestMethod]
        [Timeout(100)]
        public void DivideTest_MaxValueDivideOne()
        {
            var solution = new _029_DivideTwoIntegers();
            var result = solution.Divide(int.MaxValue, 1);

            Assert.AreEqual(int.MaxValue, result);
        }
    }
}
