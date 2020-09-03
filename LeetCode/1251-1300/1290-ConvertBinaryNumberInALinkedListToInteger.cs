//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.1 MB
// Link: https://leetcode.com/submissions/detail/326862277/
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
    public class _1290_ConvertBinaryNumberInALinkedListToInteger
    {
        public int GetDecimalValue(ListNode head)
        {
            uint result = 0;
            while (head != null)
            {
                result <<= 1;
                result += (uint)head.val;
                head = head.next;
            }

            return (int)result;
        }
    }
}
