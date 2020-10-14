//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 31 MB
// Link: https://leetcode.com/submissions/detail/408465342/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int val=0, ListNode next=null) {
     *         this.val = val;
     *         this.next = next;
     *     }
     * }
     */
    public class _0148_SortList
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode prev = null, slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            prev.next = null;

            var left = SortList(head);
            var right = SortList(slow);

            return Merge(left, right);
        }

        private ListNode Merge(ListNode left, ListNode right)
        {
            var dummy = new ListNode();
            var current = dummy;

            while (left != null && right != null)
            {
                if (left.val < right.val)
                {
                    current.next = left;
                    left = left.next;
                }
                else
                {
                    current.next = right;
                    right = right.next;
                }

                current = current.next;
            }

            if (left != null) current.next = left;
            if (right != null) current.next = right;

            return dummy.next;
        }
    }
}
