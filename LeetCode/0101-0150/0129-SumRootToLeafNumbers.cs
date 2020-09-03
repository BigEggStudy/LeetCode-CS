//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0129_SumRootToLeafNumbers
    {
        /**
         * Definition for a binary tree node.
         * public class TreeNode {
         *     public int val;
         *     public TreeNode left;
         *     public TreeNode right;
         *     public TreeNode(int x) { val = x; }
         * }
         */
        public int SumNumbers(TreeNode root)
        {
            return SumNumbers(root, 0);
        }

        private int SumNumbers(TreeNode node, int number)
        {
            if (node == null) return 0;

            var result = number * 10 + node.val;
            if (node.left == null && node.right == null) return result;
            return SumNumbers(node.left, result) + SumNumbers(node.right, result);
        }
    }
}
