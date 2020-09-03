//-----------------------------------------------------------------------------
// Runtime: 180ms
// Memory Usage: 44.6 MB
// Link: https://leetcode.com/submissions/detail/361292724/
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
    public class _1448_CountGoodNodesInBinaryTree
    {
        public int GoodNodes(TreeNode root)
        {
            return GoodNodes(root, int.MinValue);
        }

        private int GoodNodes(TreeNode root, int maxValue)
        {
            if (root == null) return 0;

            var left = GoodNodes(root.left, Math.Max(root.val, maxValue));
            var right = GoodNodes(root.right, Math.Max(root.val, maxValue));

            return left + right + (root.val >= maxValue ? 1 : 0);
        }
    }
}
