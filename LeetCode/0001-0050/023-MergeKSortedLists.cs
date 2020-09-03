//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 29.3 MB
// Link: https://leetcode.com/submissions/detail/365343393/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _023_MergeKSortedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0) return null;

            return MergeKHelper(lists, 0, lists.Length - 1);
        }

        public ListNode MergeKHelper(ListNode[] lists, int i, int j)
        {
            if (i == j) return lists[i];

            int mid = i + (j - i) / 2;
            var left = MergeKHelper(lists, i, mid);
            var right = MergeKHelper(lists, mid + 1, j);
            return MergeTwoLists(left, right);
        }

        private ListNode MergeTwoLists(ListNode l1, ListNode l2)
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
