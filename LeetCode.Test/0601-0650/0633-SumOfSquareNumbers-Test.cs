using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0633_SumOfSquareNumbers_Test
    {
        [TestMethod]
        public void JudgeSquareSum_1()
        {
            var solution = new _0633_SumOfSquareNumbers();
            var result = solution.JudgeSquareSum(5);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void JudgeSquareSum_2()
        {
            var solution = new _0633_SumOfSquareNumbers();
            var result = solution.JudgeSquareSum(3);
            Assert.IsFalse(result);
        }

        [TestMethod]
        [Timeout(20)]
        public void JudgeSquareSum_3()
        {
            var solution = new _0633_SumOfSquareNumbers();
            var result = solution.JudgeSquareSum(2147483646);
            Assert.IsFalse(result);
        }
    }
}
