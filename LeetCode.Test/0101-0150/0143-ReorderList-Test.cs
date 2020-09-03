using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0143_ReorderList_Test
    {
        [TestMethod]
        public void ReorderList_1()
        {
            var head = TestHelper.GenerateList(new int[] { 1, 2, 3, 4 });

            var solution = new _0143_ReorderList();
            solution.ReorderList(head);
            AssertHelper.AssertLinkList(new int[] { 1, 4, 2, 3 }, head);
        }

        [TestMethod]
        public void ReorderList_2()
        {
            var head = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _0143_ReorderList();
            solution.ReorderList(head);
            AssertHelper.AssertLinkList(new int[] { 1, 5, 2, 4, 3 }, head);
        }
    }
}
