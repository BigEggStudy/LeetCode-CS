//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 30.9 MB
// Link: https://leetcode.com/submissions/detail/262184542/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0235_LowestCommonAncestorOfABinarySearchTree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (p.val > q.val) return LowestCommonAncestor(root, q, p);
            if (root.val >= p.val && root.val <= q.val) return root;
            if (root.val < p.val && root.val < q.val) return LowestCommonAncestor(root.right, p, q);
            else return LowestCommonAncestor(root.left, p, q);
        }
    }
}
