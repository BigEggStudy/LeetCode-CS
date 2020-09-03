using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0371_SumOfTwoIntegers_Test
    {
        [TestMethod]
        public void GetSumTest_1()
        {
            var solution = new _0371_SumOfTwoIntegers();
            Assert.AreEqual(3, solution.GetSum(1, 2));
        }

        [TestMethod]
        public void GetSumTest_2()
        {
            var solution = new _0371_SumOfTwoIntegers();
            Assert.AreEqual(1, solution.GetSum(-2, 3));
        }

        [TestMethod]
        public void GetSumTest_3()
        {
            var solution = new _0371_SumOfTwoIntegers();
            Assert.AreEqual(-1, solution.GetSum(1, -2));
        }
    }
}
