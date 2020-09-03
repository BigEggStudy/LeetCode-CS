using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1133_LargestUniqueNumber_Test
    {
        [TestMethod]
        public void LargestUniqueNumber_1()
        {
            var solution = new _1133_LargestUniqueNumber();
            var result = solution.LargestUniqueNumber(new int[] { 5, 7, 3, 9, 4, 9, 8, 3, 1 });
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void LargestUniqueNumber_2()
        {
            var solution = new _1133_LargestUniqueNumber();
            var result = solution.LargestUniqueNumber(new int[] { 9, 9, 8, 8 });
            Assert.AreEqual(-1, result);
        }
    }
}
