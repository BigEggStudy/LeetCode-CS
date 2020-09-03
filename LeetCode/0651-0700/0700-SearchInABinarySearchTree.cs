//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 33.9 MB
// Link: https://leetcode.com/submissions/detail/354207567/
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
    public class _0700_SearchInABinarySearchTree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return null;

            if (root.val == val) return root;
            else if (root.val < val) return SearchBST(root.right, val);
            else return SearchBST(root.left, val);
        }
    }
}
