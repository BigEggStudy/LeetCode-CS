using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0153_FindMinimumInRotatedSortedArray_Test
    {
        [TestMethod]
        public void FindMinTest_1()
        {
            var solution = new _0153_FindMinimumInRotatedSortedArray();
            var result = solution.FindMin(new int[] { 3, 4, 5, 1, 2 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindMinTest_2()
        {
            var solution = new _0153_FindMinimumInRotatedSortedArray();
            var result = solution.FindMin(new int[] { 4, 5, 6, 7, 0, 1, 2 });
            Assert.AreEqual(0, result);
        }
    }
}
