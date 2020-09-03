//-----------------------------------------------------------------------------
// Runtime: 172ms
// Memory Usage: 44.5 MB
// Link: https://leetcode.com/submissions/detail/358747421/
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
    public class _0687_LongestUnivaluePath
    {
        private int result = 0;

        public int LongestUnivaluePath(TreeNode root)
        {
            result = 0;
            GetLenght(root);
            return result;
        }

        private int GetLenght(TreeNode node)
        {
            if (node == null) return 0;

            var leftLength = GetLenght(node.left);
            var rightLength = GetLenght(node.right);

            if (node.left != null && node.left.val == node.val)
                leftLength++;
            else
                leftLength = 0;

            if (node.right != null && node.right.val == node.val)
                rightLength++;
            else
                rightLength = 0;

            result = Math.Max(result, leftLength + rightLength);
            return Math.Max(leftLength, rightLength);
        }
    }
}
