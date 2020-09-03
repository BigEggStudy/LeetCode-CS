using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _092_ReverseLinkedList2_Test
    {
        [TestMethod]
        public void ReverseReverseBetweenTest()
        {
            var solution = new _092_ReverseLinkedList2();
            var link = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });
            AssertHelper.AssertLinkList(new int[] { 1, 4, 3, 2, 5 }, solution.ReverseBetween(link, 2, 4));
        }

        [TestMethod]
        public void ReverseReverseBetweenTest_NoMove()
        {
            var solution = new _092_ReverseLinkedList2();
            var link = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });
            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, solution.ReverseBetween(link, 2, 2));
        }

        [TestMethod]
        public void ReverseReverseBetweenTest_MoveHead()
        {
            var solution = new _092_ReverseLinkedList2();
            var link = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });
            AssertHelper.AssertLinkList(new int[] { 2, 1, 3, 4, 5 }, solution.ReverseBetween(link, 1, 2));
        }

        [TestMethod]
        public void ReverseReverseBetweenTest_FullyMove()
        {
            var solution = new _092_ReverseLinkedList2();
            var link = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });
            AssertHelper.AssertLinkList(new int[] { 5, 4, 3, 2, 1 }, solution.ReverseBetween(link, 1, 5));
        }
    }
}
