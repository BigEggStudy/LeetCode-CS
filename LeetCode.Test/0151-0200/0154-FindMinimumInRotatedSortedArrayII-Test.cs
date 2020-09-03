using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0154_FindMinimumInRotatedSortedArrayII_Test
    {
        [TestMethod]
        public void FindMin_1()
        {
            var solution = new _0154_FindMinimumInRotatedSortedArrayII();
            var result = solution.FindMin(new int[] { 1, 3, 5 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindMin_2()
        {
            var solution = new _0154_FindMinimumInRotatedSortedArrayII();
            var result = solution.FindMin(new int[] { 2, 2, 2, 0, 1 });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FindMin_3()
        {
            var solution = new _0154_FindMinimumInRotatedSortedArrayII();
            var result = solution.FindMin(new int[] { 2, 2, 2, 0, 2, 2, 2, 2, 2 });
            Assert.AreEqual(0, result);
        }
    }
}
