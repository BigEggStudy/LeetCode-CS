//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 30 MB
// Link: https://leetcode.com/submissions/detail/346867621/
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
    public class _0143_ReorderList
    {
        public void ReorderList(ListNode head)
        {
            if (head == null) return;

            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode prev = null, curr = slow, temp;
            while (curr != null)
            {
                temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }

            ListNode first = head, second = prev;
            while (second.next != null)
            {
                temp = first.next;
                first.next = second;
                first = temp;

                temp = second.next;
                second.next = first;
                second = temp;
            }
        }
    }
}
