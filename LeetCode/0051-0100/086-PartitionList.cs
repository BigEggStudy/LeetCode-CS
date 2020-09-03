//-----------------------------------------------------------------------------
// Runtime: 148ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _086_PartitionList
    {
        public ListNode Partition(ListNode head, int x)
        {
            var lessThanHead = new ListNode(-1);
            var greaterThanHead = new ListNode(-1);

            ListNode p = head, lessP = lessThanHead, greaterP = greaterThanHead;
            while (p != null)
            {
                if (p.val < x)
                {
                    lessP.next = p;
                    lessP = lessP.next;
                }
                else
                {
                    greaterP.next = p;
                    greaterP = greaterP.next;
                }
                p = p.next;
            }
            lessP.next = greaterThanHead.next;
            greaterP.next = null;
            return lessThanHead.next;
        }
    }
}
