//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.6 MB
// Link: https://leetcode.com/submissions/detail/344255488/
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
    public class _0404_SumOfLeftLeaves
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            return Compute(root, false);
        }

        private int Compute(TreeNode node, bool left)
        {
            if (node == null) return 0;
            if (node.left == null && node.right == null)
                return left ? node.val : 0;

            return Compute(node.left, true) + Compute(node.right, false);
        }
    }
}
