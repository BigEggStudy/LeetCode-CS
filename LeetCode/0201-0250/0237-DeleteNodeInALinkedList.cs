//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 24.2 MB
// Link: https://leetcode.com/submissions/detail/263755695/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0237_DeleteNodeInALinkedList
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
