//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 26.6 MB
// Link: https://leetcode.com/submissions/detail/370200185/
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
    public class _1120_MaximumAverageSubtree
    {
        private double maxAverage = double.MinValue;

        public double MaximumAverageSubtree(TreeNode root)
        {
            Traversal(root);
            return maxAverage;
        }

        private (int sum, int count) Traversal(TreeNode node)
        {
            if (node == null) return (0, 0);

            (int leftSum, int leftCount) = Traversal(node.left);
            (int rightSum, int rightCount) = Traversal(node.right);

            var sum = leftSum + rightSum + node.val;
            var count = leftCount + rightCount + 1;

            maxAverage = Math.Max(maxAverage, 1.0 * sum / count);

            return (sum, count);
        }
    }
}
