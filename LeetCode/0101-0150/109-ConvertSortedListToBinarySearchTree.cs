//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _109_ConvertSortedListToBinarySearchTree
    {
        private ListNode head = null;

        public TreeNode SortedListToBST(ListNode head)
        {
            var p = head;
            var length = 0;
            while (p != null)
            {
                p = p.next;
                length++;
            }

            this.head = head;

            return SortedListToBST(0, length);
        }

        public TreeNode SortedListToBST(int l, int r)
        {
            if (l >= r) return null;
            var mid = l + (r - l) / 2;

            var left = SortedListToBST(l, mid);
            var node = new TreeNode(head.val);
            node.left = left;
            this.head = this.head.next;
            node.right = SortedListToBST(mid + 1, r);
            return node;
        }
    }
}
