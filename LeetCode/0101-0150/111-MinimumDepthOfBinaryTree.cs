//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 26.1 MB
// Link: https://leetcode.com/submissions/detail/358687367/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _111_MinimumDepthOfBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null) return MinDepth(root.right) + 1;
            if (root.right == null) return MinDepth(root.left) + 1;
            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
    }
}
