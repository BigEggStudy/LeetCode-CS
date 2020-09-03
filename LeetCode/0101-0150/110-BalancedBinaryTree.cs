//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 27.4 MB
// Link: https://leetcode.com/submissions/detail/352794483/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _110_BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            return GetHeight(root) != -1;
        }

        private int GetHeight(TreeNode current)
        {
            if (current == null) return 0;
            var leftHeight = GetHeight(current.left);
            if (leftHeight == -1) return -1;
            var rightHeight = GetHeight(current.right);
            if (rightHeight == -1) return -1;
            if (Math.Abs(leftHeight - rightHeight) > 1) return -1;
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
