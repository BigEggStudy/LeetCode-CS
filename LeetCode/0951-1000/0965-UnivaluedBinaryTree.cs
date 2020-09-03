//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.2 MB
// Link: https://leetcode.com/submissions/detail/330687267/
//-----------------------------------------------------------------------------

namespace LeetCode
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
    public class _0965_UnivaluedBinaryTree
    {
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null) return true;
            if (root.left != null && root.left.val != root.val) return false;
            if (root.right != null && root.right.val != root.val) return false;

            return IsUnivalTree(root.left) && IsUnivalTree(root.right);
        }
    }
}
