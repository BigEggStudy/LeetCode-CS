//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25.6 MB
// Link: https://leetcode.com/submissions/detail/340551981/
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
    public class _0328_OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null) return null;
            ListNode odd = head, even = head.next, evenHead = even;
            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }

            odd.next = evenHead;
            return head;
        }
    }
}
