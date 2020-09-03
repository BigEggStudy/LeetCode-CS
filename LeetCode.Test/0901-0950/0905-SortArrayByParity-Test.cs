using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0905_SortArrayByParity_Test
    {
        [TestMethod]
        public void SortArrayByParity_1()
        {
            var solution = new _0905_SortArrayByParity();
            var result = solution.SortArrayByParity(new int[] { 3, 1, 2, 4 });
            AssertHelper.AssertArray(new int[] { 4, 2, 1, 3 }, result);
        }

        [TestMethod]
        public void SortArrayByParity_2()
        {
            var solution = new _0905_SortArrayByParity();
            var result = solution.SortArrayByParity(new int[] { 4, 2, 1, 3 });
            AssertHelper.AssertArray(new int[] { 4, 2, 1, 3 }, result);
        }

        [TestMethod]
        public void SortArrayByParity_3()
        {
            var solution = new _0905_SortArrayByParity();
            var result = solution.SortArrayByParity(new int[] { 3, 1, 5, 2, 4 });
            AssertHelper.AssertArray(new int[] { 4, 2, 5, 1, 3 }, result);
        }
    }
}
