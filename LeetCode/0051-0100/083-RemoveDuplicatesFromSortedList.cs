//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25.9 MB
// Link: https://leetcode.com/submissions/detail/352391274/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _083_RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) { return null; }

            var p = head;
            while (p.next != null)
            {
                if (p.val == p.next.val)
                    p.next = p.next.next;
                else
                    p = p.next;
            }

            return head;
        }
    }
}
