//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0979_DistributeCoinsInBinaryTree
    {
        private int result = 0;

        public int DistributeCoins(TreeNode root)
        {
            result = 0;
            DistributeCoinsCore(root);
            return result;
        }

        public int DistributeCoinsCore(TreeNode node)
        {
            if (node == null) return 0;
            var left = DistributeCoinsCore(node.left);
            var right = DistributeCoinsCore(node.right);
            result += Math.Abs(left) + Math.Abs(right);
            return left + right + node.val - 1;
        }
    }
}
