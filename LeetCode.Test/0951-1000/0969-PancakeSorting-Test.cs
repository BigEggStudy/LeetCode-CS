using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0969_PancakeSorting_Test
    {
        [TestMethod]
        public void PancakeSort_1()
        {
            var solution = new _0969_PancakeSorting();
            var result = solution.PancakeSort(new int[] { 3, 2, 4, 1 });
            AssertHelper.AssertList(new int[] { 3, 4, 2, 3, 1, 2 }, result);
        }

        [TestMethod]
        public void PancakeSort_2()
        {
            var solution = new _0969_PancakeSorting();
            var result = solution.PancakeSort(new int[] { 1, 2, 3 });
            Assert.AreEqual(0, result.Count);
        }
    }
}
