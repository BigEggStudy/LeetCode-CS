//-----------------------------------------------------------------------------
// Runtime: 152ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _019_RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null || n <= 0) { return null; }

            ListNode fakeHead, node1, node2;
            fakeHead = new ListNode(-1);
            fakeHead.next = head;

            node1 = node2 = fakeHead;
            for (int i = 0; i < n; i++)
            {
                if (node1 == null) { return null; }
                node1 = node1.next;
            }

            if (node1 != null)
            {
                while (node1.next != null)
                {
                    node1 = node1.next;
                    node2 = node2.next;
                }
                node2.next = node2.next.next;
            }
            return fakeHead.next;
        }
    }
}
