//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 25.7 MB
// Link: https://leetcode.com/submissions/detail/339141239/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _108_ConvertSortedArrayToBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArraryToBST(nums, 0, nums.Length);
        }

        private TreeNode SortedArraryToBST(int[] nums, int l, int r)
        {
            if (l >= r) return null;
            var mid = (r - l) / 2 + l;

            var node = new TreeNode(nums[mid]);
            node.left = SortedArraryToBST(nums, l, mid);
            node.right = SortedArraryToBST(nums, mid + 1, r);
            return node;
        }
    }
}
