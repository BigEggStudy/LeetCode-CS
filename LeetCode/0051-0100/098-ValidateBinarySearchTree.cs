//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 26.1 MB
// Link: https://leetcode.com/submissions/detail/378629338/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _098_ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, long.MinValue, long.MaxValue);
        }

        public bool IsValidBST(TreeNode current, long low, long high)
        {
            if (current == null) return true;
            if (current.val <= low || current.val >= high) return false;

            return IsValidBST(current.left, low, current.val) && IsValidBST(current.right, current.val, high);
        }
    }
}
