using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0206_ReverseLinkedList_Test
    {
        [TestMethod]
        public void ReverseListTest()
        {
            var head = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _0206_ReverseLinkedList();
            var newHead = solution.ReverseList(head);
            AssertHelper.AssertLinkList(new int[] { 5, 4, 3, 2, 1 }, newHead);
        }
    }
}
