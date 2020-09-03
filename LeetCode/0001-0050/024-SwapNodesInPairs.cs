//-----------------------------------------------------------------------------
// Runtime: 148ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _024_SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            var dummyHead = new ListNode(-1);
            dummyHead.next = head;
            ListNode p = dummyHead, q;

            while (p.next != null && p.next.next != null)
            {
                q = p.next;
                p.next = q.next;
                q.next = p.next.next;
                p.next.next = q;

                p = q;
            }

            return dummyHead.next;
        }
    }
}
