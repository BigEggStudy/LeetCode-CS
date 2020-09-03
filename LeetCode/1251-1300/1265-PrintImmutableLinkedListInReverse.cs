//-----------------------------------------------------------------------------
// Runtime: 232MS
// Memory Usage: 30.1 MB
// Link: https://leetcode.com/submissions/detail/359629468/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    /**
     * // This is the ImmutableListNode's API interface.
     * // You should not implement it, or speculate about its implementation.
     * class ImmutableListNode {
     *     public void PrintValue(); // print the value of this node.
     *     public ImmutableListNode GetNext(); // return the next node.
     * }
     */

    public class _1265_PrintImmutableLinkedListInReverse
    {
        public void PrintLinkedListInReverse(ImmutableListNode head)
        {
            if (head == null) return;

            PrintLinkedListInReverse(head.GetNext());
            head.PrintValue();
        }

        public class ImmutableListNode : ListNode
        {
            private readonly IList<int> list;

            public ImmutableListNode(IList<int> list, int value, ImmutableListNode next)
                : base(value)
            {
                this.list = list;
                this.next = next;
            }

            public void PrintValue()
            {
                list.Add(val);
            }

            public ImmutableListNode GetNext()
            {
                return (ImmutableListNode)next;
            }
        }
    }
}
