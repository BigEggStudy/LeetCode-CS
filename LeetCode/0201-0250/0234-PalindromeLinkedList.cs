//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 28 MB
// Link: https://leetcode.com/submissions/detail/358330538/
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
    public class _0234_PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null) return true;

            var endOfFirstHalf = EndOfFirstHalf(head);
            var secondHalf = ReverseList(endOfFirstHalf.next);

            ListNode p1 = head, p2 = secondHalf;
            var result = true;
            while (p2 != null)
            {
                if (p1.val != p2.val)
                {
                    result = false;
                    break;
                }

                p1 = p1.next;
                p2 = p2.next;
            }

            return result;
        }

        private ListNode EndOfFirstHalf(ListNode head)
        {
            ListNode slow = head, fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }

        private ListNode ReverseList(ListNode head)
        {
            ListNode prev = null, curr = head;
            while (curr != null)
            {
                var next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }
    }
}
