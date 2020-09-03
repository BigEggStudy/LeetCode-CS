//-----------------------------------------------------------------------------
// Runtime: 168ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _082_RemoveDuplicatesFromSortedList2
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var first = new ListNode(-1)
            {
                next = head
            };

            bool isDuplicate = false;
            var prev = first;

            for (var p = head; p != null && p.next != null; p = p.next)
            {
                if (!isDuplicate)
                    if (p.val == p.next.val)
                        isDuplicate = true;
                    else
                        prev = p;
                else if (p.val != p.next.val)
                {
                    isDuplicate = false;
                    prev.next = p.next;
                }
            }
            if (isDuplicate)
            {
                prev.next = null;
            }

            return first.next;
        }
    }
}
