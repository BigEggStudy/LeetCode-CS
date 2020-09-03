//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 25.7 MB
// Link: https://leetcode.com/submissions/detail/343624394/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _021_MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var head = new ListNode(-1);
            var current = head;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }

            current.next = l1 == null ? l2 : l1;
            return head.next;
        }
    }
}
