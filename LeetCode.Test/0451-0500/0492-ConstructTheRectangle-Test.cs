using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0492_ConstructTheRectangle_Test
    {
        [TestMethod]
        public void ConstructRectangle_1()
        {
            var solution = new _0492_ConstructTheRectangle();
            var result = solution.ConstructRectangle(4);
            AssertHelper.AssertArray(new int[] { 2, 2 }, result);
        }
    }
}
