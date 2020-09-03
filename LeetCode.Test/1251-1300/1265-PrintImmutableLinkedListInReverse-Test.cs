using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _1265_PrintImmutableLinkedListInReverse_Test
    {
        [TestMethod]
        public void PrintLinkedListInReverse_1()
        {
            var result = new List<int>();

            var node4 = new _1265_PrintImmutableLinkedListInReverse.ImmutableListNode(result, 4, null);
            var node3 = new _1265_PrintImmutableLinkedListInReverse.ImmutableListNode(result, 3, node4);
            var node2 = new _1265_PrintImmutableLinkedListInReverse.ImmutableListNode(result, 2, node3);
            var node1 = new _1265_PrintImmutableLinkedListInReverse.ImmutableListNode(result, 1, node2);

            var solution = new _1265_PrintImmutableLinkedListInReverse();
            solution.PrintLinkedListInReverse(node1);
            AssertHelper.AssertList(new int[] { 4, 3, 2, 1 }, result);
        }

        [TestMethod]
        public void PrintLinkedListInReverse_2()
        {
            var result = new List<int>();

            var node5 = new _1265_PrintImmutableLinkedListInReverse.ImmutableListNode(result, -5, null);
            var node4 = new _1265_PrintImmutableLinkedListInReverse.ImmutableListNode(result, 3, node5);
            var node3 = new _1265_PrintImmutableLinkedListInReverse.ImmutableListNode(result, -1, node4);
            var node2 = new _1265_PrintImmutableLinkedListInReverse.ImmutableListNode(result, -4, node3);
            var node1 = new _1265_PrintImmutableLinkedListInReverse.ImmutableListNode(result, 0, node2);

            var solution = new _1265_PrintImmutableLinkedListInReverse();
            solution.PrintLinkedListInReverse(node1);
            AssertHelper.AssertList(new int[] { -5, 3, -1, -4, 0 }, result);
        }

        [TestMethod]
        public void PrintLinkedListInReverse_3()
        {
            var result = new List<int>();

            var node6 = new _1265_PrintImmutableLinkedListInReverse.ImmutableListNode(result, -6, null);
            var node5 = new _1265_PrintImmutableLinkedListInReverse.ImmutableListNode(result, 4, node6);
            var node4 = new _1265_PrintImmutableLinkedListInReverse.ImmutableListNode(result, 4, node5);
            var node3 = new _1265_PrintImmutableLinkedListInReverse.ImmutableListNode(result, 6, node4);
            var node2 = new _1265_PrintImmutableLinkedListInReverse.ImmutableListNode(result, 0, node3);
            var node1 = new _1265_PrintImmutableLinkedListInReverse.ImmutableListNode(result, -2, node2);

            var solution = new _1265_PrintImmutableLinkedListInReverse();
            solution.PrintLinkedListInReverse(node1);
            AssertHelper.AssertList(new int[] { -6, 4, 4, 6, 0, -2 }, result);
        }
    }
}
