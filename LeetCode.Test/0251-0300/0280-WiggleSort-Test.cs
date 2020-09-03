using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0280_WiggleSort_Test
    {
        [TestMethod]
        public void WiggleSort_1()
        {
            var arr = new int[] { 3, 5, 2, 1, 6, 4 };

            var solution = new _0280_WiggleSort();
            solution.WiggleSort(arr);
            AssertHelper.AssertArray(new int[] { 3, 5, 1, 6, 2, 4 }, arr);
        }
    }
}
