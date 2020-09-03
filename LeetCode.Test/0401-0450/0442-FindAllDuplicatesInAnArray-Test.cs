using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0442_FindAllDuplicatesInAnArray_Test
    {
        [TestMethod]
        public void FindDuplicates_1()
        {
            var solution = new _0442_FindAllDuplicatesInAnArray();
            var result = solution.FindDuplicates(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });
            AssertHelper.AssertList(new int[] { 2, 3 }, result);
        }
    }
}
