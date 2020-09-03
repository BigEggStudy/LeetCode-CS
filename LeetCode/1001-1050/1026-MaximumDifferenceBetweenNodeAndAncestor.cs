//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 24.6 MB
// Link: https://leetcode.com/submissions/detail/364019812/
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
    public class _1026_MaximumDifferenceBetweenNodeAndAncestor
    {
        public int MaxAncestorDiff(TreeNode root)
        {
            return MaxAncestorDiff(root, root.val, root.val);
        }

        private int MaxAncestorDiff(TreeNode node, int min, int max)
        {
            if (node == null) return max - min;

            if (node.val < min)
                min = node.val;
            else if (node.val > max)
                max = node.val;

            return Math.Max(MaxAncestorDiff(node.left, min, max), MaxAncestorDiff(node.right, min, max));
        }
    }
}
