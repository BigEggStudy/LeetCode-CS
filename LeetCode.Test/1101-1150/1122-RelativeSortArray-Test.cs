using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1122_RelativeSortArray_Test
    {
        [TestMethod]
        public void RelativeSortArray_1()
        {
            var solution = new _1122_RelativeSortArray();
            var result = solution.RelativeSortArray(new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 }, new int[] { 2, 1, 4, 3, 9, 6 });
            AssertHelper.AssertArray(new int[] { 2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19 }, result);
        }
    }
}
