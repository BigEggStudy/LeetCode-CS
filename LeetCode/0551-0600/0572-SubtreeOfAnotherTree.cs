//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 27.9 MB
// Link: https://leetcode.com/submissions/detail/352434406/
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
    public class _0572_SubtreeOfAnotherTree
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            return Traverse(s, t);
        }

        private bool Traverse(TreeNode s, TreeNode t)
        {
            return s != null && (EqualTree(s, t) || Traverse(s.left, t) || Traverse(s.right, t));
        }

        private bool EqualTree(TreeNode s, TreeNode t)
        {
            if (s == null && t == null) return true;
            if (s == null || t == null) return false;
            return s.val == t.val && EqualTree(s.left, t.left) && EqualTree(s.right, t.right);
        }
    }
}
