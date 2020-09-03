//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 25.3 MB
// Link: https://leetcode.com/submissions/detail/333021377/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _104_MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            return Math.Max(1 + MaxDepth(root.left), 1 + MaxDepth(root.right));
        }
    }
}
