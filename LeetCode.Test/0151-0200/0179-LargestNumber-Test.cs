using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0179_LargestNumber_Test
    {
        [TestMethod]
        public void LargestNumber_1()
        {
            var solution = new _0179_LargestNumber();
            var result = solution.LargestNumber(new int[] { 10, 2 });
            Assert.AreEqual("210", result);
        }

        [TestMethod]
        public void LargestNumber_2()
        {
            var solution = new _0179_LargestNumber();
            var result = solution.LargestNumber(new int[] { 3, 30, 34, 5, 9 });
            Assert.AreEqual("9534330", result);
        }
    }
}
