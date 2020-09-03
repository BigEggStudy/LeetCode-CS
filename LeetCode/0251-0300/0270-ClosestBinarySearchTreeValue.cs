//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 26 MB
// Link: https://leetcode.com/submissions/detail/351914327/
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
    public class _0270_ClosestBinarySearchTreeValue
    {
        private int result = 0;

        public int ClosestValue(TreeNode root, double target)
        {
            result = root.val;
            BinarySearch(root, target);
            return result;
        }

        private void BinarySearch(TreeNode node, double target)
        {
            if (node == null) return;

            if (Math.Abs(target - node.val) < Math.Abs(result - target))
                result = node.val;

            if (node.val > target)
                BinarySearch(node.left, target);
            else if (node.val < target)
                BinarySearch(node.right, target);
        }
    }
}
