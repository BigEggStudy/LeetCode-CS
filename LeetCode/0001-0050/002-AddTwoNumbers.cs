//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 27.3 MB
// Link: https://leetcode.com/submissions/detail/378602405/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _002_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var dummy = new ListNode(-1);
            var current = dummy;

            var carry = 0;
            while (l1 != null || l2 != null)
            {
                var value1 = l1 == null ? 0 : l1.val;
                var value2 = l2 == null ? 0 : l2.val;

                var sum = value1 + value2 + carry;
                carry = sum / 10;
                sum %= 10;
                current.next = new ListNode(sum);

                current = current.next;
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }

            if (carry != 0)
                current.next = new ListNode(carry);

            return dummy.next;
        }
    }
}
