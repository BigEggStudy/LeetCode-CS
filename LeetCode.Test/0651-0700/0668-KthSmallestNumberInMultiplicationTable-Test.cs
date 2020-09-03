using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0668_KthSmallestNumberInMultiplicationTable_Test
    {
        [TestMethod]
        public void FindKthNumberTest_1()
        {
            var solution = new _0668_KthSmallestNumberInMultiplicationTable();
            var result = solution.FindKthNumber(3, 3, 5);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FindKthNumberTest_2()
        {
            var solution = new _0668_KthSmallestNumberInMultiplicationTable();
            var result = solution.FindKthNumber(2, 3, 6);
            Assert.AreEqual(6, result);
        }
    }
}
