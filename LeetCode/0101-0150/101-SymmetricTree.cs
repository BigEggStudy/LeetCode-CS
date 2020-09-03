//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 25.2 MB
// Link: https://leetcode.com/submissions/detail/352327152/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _101_SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return isMirror(root.left, root.right);
        }

        private bool isMirror(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return true;
            if (root1 == null || root2 == null) return false;
            if (root1.val != root2.val) return false;
            return isMirror(root1.left, root2.right) && isMirror(root1.right, root2.left);
        }
    }
}
