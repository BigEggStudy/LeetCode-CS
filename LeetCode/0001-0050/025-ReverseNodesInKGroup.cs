//-----------------------------------------------------------------------------
// Runtime: 160ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _025_ReverseNodesInKGroup
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (k <= 1) { return head; }

            var dummyHead = new ListNode(-1);
            dummyHead.next = head;
            ListNode p = dummyHead, q, r;
            int i = 0;

            while (p.next != null)
            {
                q = p.next;
                for (i = 0; i < k; i++)
                {
                    if (q == null) { return dummyHead.next; }
                    q = q.next;
                }

                q = p.next;
                for (i = 1; i < k; i++)
                {
                    r = q.next;
                    q.next = r.next;
                    r.next = p.next;
                    p.next = r;
                }

                p = q;
            }

            return dummyHead.next;
        }
    }
}
