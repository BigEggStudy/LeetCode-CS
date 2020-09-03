//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.3 MB
// Link: https://leetcode.com/submissions/detail/343624904/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _100_SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (q == null && p == null) return true;
            if (p == null || q == null) return false;
            if (p.val != q.val) return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
