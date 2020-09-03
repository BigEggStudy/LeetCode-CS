using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0852_PeakIndexInAMountainArray_Test
    {
        [TestMethod]
        public void PeakIndexInMountainArray_1()
        {
            var solution = new _0852_PeakIndexInAMountainArray();
            var result = solution.PeakIndexInMountainArray(new int[] { 0, 1, 0 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void PeakIndexInMountainArray_2()
        {
            var solution = new _0852_PeakIndexInAMountainArray();
            var result = solution.PeakIndexInMountainArray(new int[] { 0, 2, 1, 0 });
            Assert.AreEqual(1, result);
        }
    }
}
