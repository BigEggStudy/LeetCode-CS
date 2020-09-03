using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1474_DeleteNNodesAfterMNodesOfALinkedList_Test
    {
        [TestMethod]
        public void DeleteNodes_1()
        {
            var head = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 });

            var solution = new _1474_DeleteNNodesAfterMNodesOfALinkedList();
            var result = solution.DeleteNodes(head, 2, 3);
            AssertHelper.AssertLinkList(new int[] { 1, 2, 6, 7, 11, 12 }, result);
        }

        [TestMethod]
        public void DeleteNodes_2()
        {
            var head = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });

            var solution = new _1474_DeleteNNodesAfterMNodesOfALinkedList();
            var result = solution.DeleteNodes(head, 1, 3);
            AssertHelper.AssertLinkList(new int[] { 1, 5, 9 }, result);
        }

        [TestMethod]
        public void DeleteNodes_3()
        {
            var head = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });

            var solution = new _1474_DeleteNNodesAfterMNodesOfALinkedList();
            var result = solution.DeleteNodes(head, 3, 1);
            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 5, 6, 7, 9, 10, 11 }, result);
        }

        [TestMethod]
        public void DeleteNodes_4()
        {
            var head = TestHelper.GenerateList(new int[] { 9, 3, 7, 7, 9, 10, 8, 2 });

            var solution = new _1474_DeleteNNodesAfterMNodesOfALinkedList();
            var result = solution.DeleteNodes(head, 1, 2);
            AssertHelper.AssertLinkList(new int[] { 9, 7, 8 }, result);
        }
    }
}
