//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 26.6 MB
// Link: https://leetcode.com/submissions/detail/363101945/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
     *         this.val = val;
     *         this.left = left;
     *         this.right = right;
     *     }
     * }
     */
    public class _1123_LowestCommonAncestorOfDeepestLeaves
    {
        private int maxDepth = 0;
        private TreeNode result = null;

        public TreeNode LcaDeepestLeaves(TreeNode root)
        {
            Helper(root, 0);
            return result;
        }

        public int Helper(TreeNode node, int level)
        {
            if (node == null)
                return 0;

            int left = Helper(node.left, level + 1);
            int right = Helper(node.right, level + 1);

            if (left == right && level + left >= maxDepth)
            {
                maxDepth = level + left;
                result = node;
            }

            return Math.Max(left, right) + 1;
        }
    }
}
