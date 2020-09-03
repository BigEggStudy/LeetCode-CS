//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 28.4 MB
// Link: https://leetcode.com/submissions/detail/257942576/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0124_BinaryTreeMaximumPathSum
    {
        private int max_sum = int.MinValue;

        public int MaxPathSum(TreeNode root)
        {
            MaxPathSumCore(root);
            return max_sum;
        }

        public int MaxPathSumCore(TreeNode root)
        {
            if (root == null) return 0;

            var leftSum = Math.Max(MaxPathSumCore(root.left), 0);
            var rightSum = Math.Max(MaxPathSumCore(root.right), 0);

            max_sum = Math.Max(max_sum, root.val + leftSum + rightSum);

            return root.val + Math.Max(leftSum, rightSum);
        }
    }
}
