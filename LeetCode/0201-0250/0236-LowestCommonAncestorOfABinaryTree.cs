//-----------------------------------------------------------------------------
// Runtime: 100 ms
// Memory Usage: 28.4 MB
// Link: https://leetcode.com/submissions/detail/378623125/
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
    public class _0236_LowestCommonAncestorOfABinaryTree
    {
        private TreeNode result;

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            Find(root, p, q);
            return result;
        }

        public bool Find(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return false;

            var left = Find(root.left, p, q) ? 1 : 0;
            var right = Find(root.right, p, q) ? 1 : 0;
            var self = (root == p || root == q) ? 1 : 0;

            if (left + right + self >= 2) result = root;
            return left + right + self > 0;
        }
    }
}
