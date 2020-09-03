//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 28.4 MB
// Link: https://leetcode.com/submissions/detail/351859220/
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
    public class _0563_BinaryTreeTilt
    {
        public int FindTilt(TreeNode root)
        {
            (_, int tilt) = ComputeSum(root);
            return tilt;
        }

        private (int sum, int tilt) ComputeSum(TreeNode node)
        {
            if (node == null) return (0, 0);

            (var leftSum, var leftTilt) = ComputeSum(node.left);
            (var rightSum, var rightTilt) = ComputeSum(node.right);

            var tile = Math.Abs(leftSum - rightSum);

            return (leftSum + rightSum + node.val, tile + leftTilt + rightTilt);
        }
    }
}
