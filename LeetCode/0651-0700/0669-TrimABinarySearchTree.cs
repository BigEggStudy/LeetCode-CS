//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 27.2 MB
// Link: https://leetcode.com/submissions/detail/262180407/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0669_TrimABinarySearchTree
    {
        public TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null) return null;
            if (root.val > R) return TrimBST(root.left, L, R);
            if (root.val < L) return TrimBST(root.right, L, R);

            root.left = TrimBST(root.left, L, R);
            root.right = TrimBST(root.right, L, R);
            return root;
        }
    }
}
