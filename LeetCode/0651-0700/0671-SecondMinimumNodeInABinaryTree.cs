//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 23.9 MB
// Link: https://leetcode.com/submissions/detail/352800359/
//-----------------------------------------------------------------------------

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
    public class _0671_SecondMinimumNodeInABinaryTree
    {
        private int min = int.MaxValue;
        private long result = long.MaxValue;

        public int FindSecondMinimumValue(TreeNode root)
        {
            min = root.val;
            Traverse(root);
            return (result == long.MaxValue) ? -1 : (int)result;
        }

        private void Traverse(TreeNode node)
        {
            if (node == null) return;
            if (node.val > result) return;

            if (min < node.val && result > node.val)
                result = node.val;
            else
            {
                Traverse(node.left);
                Traverse(node.right);
            }
        }
    }
}
