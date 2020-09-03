//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 23.5 MB
// Link: https://leetcode.com/submissions/detail/260382381/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0206_ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            var dummyHead = new ListNode(-1);

            var current = head;
            while (current != null)
            {
                var next = current.next;

                current.next = dummyHead.next;
                dummyHead.next = current;

                current = next;
            }

            return dummyHead.next;
        }
    }
}
