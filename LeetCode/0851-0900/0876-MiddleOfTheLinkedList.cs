//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 23.8 MB
// Link: https://leetcode.com/submissions/detail/321762403/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0876_MiddleOfTheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            var fast = head;
            var slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            return slow;
        }
    }
}
