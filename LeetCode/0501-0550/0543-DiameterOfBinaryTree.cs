//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 25.9 MB
// Link: https://leetcode.com/submissions/detail/323354884/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0543_DiameterOfBinaryTree
    {
        private int answer;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            GetEdgeDepth(root);
            return answer;
        }

        private int GetEdgeDepth(TreeNode root)
        {
            if (root == null) return 0;

            var left = GetEdgeDepth(root.left);
            var right = GetEdgeDepth(root.right);

            this.answer = Math.Max(this.answer, left + right);
            return Math.Max(left, right) + 1;
        }
    }
}
