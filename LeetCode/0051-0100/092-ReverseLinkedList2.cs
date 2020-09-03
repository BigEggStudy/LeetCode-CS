//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _092_ReverseLinkedList2
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (m == n) { return head; }

            ListNode dummyHead = new ListNode(-1);
            dummyHead.next = head;
            ListNode p = dummyHead, q, r;
            int i = 0;
            
            for (i = 0; i < m - 1; i++)
            {
                p = p.next;
            }

            q = p.next;
            for (i = m; i < n; i++)
            {
                r = q.next;
                q.next = r.next;
                r.next = p.next;
                p.next = r;
            }

            return dummyHead.next;
        }
    }
}
