//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 25.6 MB
// Link: https://leetcode.com/submissions/detail/352953685/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) {
     *         val = x;
     *         next = null;
     *     }
     * }
     */
    public class _0141_LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;

            ListNode slow = head, fast = head.next;
            while (slow != fast)
            {
                if (fast == null || fast.next == null) return false;
                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
        }
    }
}
