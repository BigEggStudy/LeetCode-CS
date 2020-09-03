//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 27.8 MB
// Link: https://leetcode.com/submissions/detail/358364330/
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
    public class _0203_RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            var dummy = new ListNode(-1);
            dummy.next = head;
            ListNode prev = dummy, curr = head;
            while (curr != null)
            {
                if (curr.val == val)
                    prev.next = curr.next;
                else
                    prev = prev.next;
                curr = curr.next;
            }

            return dummy.next;
        }
    }
}
