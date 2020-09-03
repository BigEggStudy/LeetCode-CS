//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 31.4 MB
// Link: https://leetcode.com/submissions/detail/379032953/
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
    public class _0285_InorderSuccessorInBST
    {
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            if (p.right != null)
            {
                p = p.right;
                while (p.left != null)
                    p = p.left;
                return p;
            }

            TreeNode successor = null;
            while (root != null)
            {
                if (p.val < root.val)
                {
                    successor = root;
                    root = root.left;
                }
                else
                    root = root.right;
            }
            return successor;
        }
    }
}
