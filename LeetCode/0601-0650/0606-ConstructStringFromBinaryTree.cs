//-----------------------------------------------------------------------------
// Runtime: 120ms
// Memory Usage: 46.7 MB
// Link: https://leetcode.com/submissions/detail/343397347/
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
    public class _0606_ConstructStringFromBinaryTree
    {
        public string Tree2str(TreeNode t)
        {
            if (t == null) return string.Empty;
            if (t.left == null && t.right == null) return $"{t.val}";
            if (t.right == null) return $"{t.val}({Tree2str(t.left)})";
            return $"{t.val}({Tree2str(t.left)})({Tree2str(t.right)})";
        }
    }
}
