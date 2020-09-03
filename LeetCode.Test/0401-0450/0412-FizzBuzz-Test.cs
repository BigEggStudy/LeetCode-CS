using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0412_FizzBuzz_Test
    {
        [TestMethod]
        public void FizzBuzz_1()
        {
            var solution = new _0412_FizzBuzz();
            var result = solution.FizzBuzz(15);
            AssertHelper.AssertList(new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" }, result);
        }
    }
}
