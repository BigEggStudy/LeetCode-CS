//-----------------------------------------------------------------------------
// Runtime: 152ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _061_RotateList
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (k <= 0 || head == null) { return head; }

            var ptr = new ListNode(-1);
            ptr.next = head;

            int lenght = 0;
            while (ptr.next != null)
            {
                ptr = ptr.next;
                lenght++;
            }
            ptr.next = head;

            var rest = lenght - k % lenght;
            for (int i = 0; i < rest; i++)
            {
                ptr = ptr.next;
            }

            head = ptr.next;
            ptr.next = null;
            return head;
        }
    }
}
