//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 24.6 MB
// Link: https://leetcode.com/submissions/detail/364003868/
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
    public class _0951_FlipEquivalentBinaryTrees
    {
        public bool FlipEquiv(TreeNode root1, TreeNode root2)
        {
            if (root1 == null) return root2 == null;
            if (root2 == null) return root1 == null;
            if (root1.val != root2.val) return false;

            return (FlipEquiv(root1.left, root2.left) && FlipEquiv(root1.right, root2.right)) ||
                   (FlipEquiv(root1.left, root2.right) && FlipEquiv(root1.right, root2.left));
        }
    }
}
