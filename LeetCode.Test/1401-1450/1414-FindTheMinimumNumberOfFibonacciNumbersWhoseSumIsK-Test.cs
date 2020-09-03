using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1414_FindTheMinimumNumberOfFibonacciNumbersWhoseSumIsK_Test
    {
        [TestMethod]
        public void FindMinFibonacciNumbers_1()
        {
            var solution = new _1414_FindTheMinimumNumberOfFibonacciNumbersWhoseSumIsK();
            var result = solution.FindMinFibonacciNumbers(7);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindMinFibonacciNumbers_2()
        {
            var solution = new _1414_FindTheMinimumNumberOfFibonacciNumbersWhoseSumIsK();
            var result = solution.FindMinFibonacciNumbers(10);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindMinFibonacciNumbers_3()
        {
            var solution = new _1414_FindTheMinimumNumberOfFibonacciNumbersWhoseSumIsK();
            var result = solution.FindMinFibonacciNumbers(19);
            Assert.AreEqual(3, result);
        }
    }
}
