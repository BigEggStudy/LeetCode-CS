//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 36 MB
// Link: https://leetcode.com/submissions/detail/358320296/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) { val = x; }
     * }
     */
    public class _0160_IntersectionOfTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var p1 = headA;
            var p2 = headB;

            while (p1 != p2)
            {
                p1 = p1 == null ? headB : p1.next;
                p2 = p2 == null ? headA : p2.next;
            }

            return p1;
        }
    }
}
