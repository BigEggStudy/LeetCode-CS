using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0328_OddEvenLinkedList_Test
    {
        [TestMethod]
        public void OddEvenList_1()
        {
            var head = TestHelper.GenerateList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _0328_OddEvenLinkedList();
            var result = solution.OddEvenList(head);
            AssertHelper.AssertLinkList(new int[] { 1, 3, 5, 2, 4 }, result);
        }

        [TestMethod]
        public void OddEvenList_2()
        {
            var head = TestHelper.GenerateList(new int[] { 2, 1, 3, 5, 6, 4, 7 });

            var solution = new _0328_OddEvenLinkedList();
            var result = solution.OddEvenList(head);
            AssertHelper.AssertLinkList(new int[] { 2, 3, 6, 7, 1, 5, 4 }, result);
        }
    }
}
