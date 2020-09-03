//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 23.9 MB
// Link: https://leetcode.com/submissions/detail/330123565/
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
    public class _0897_IncreasingOrderSearchTree
    {
        private TreeNode currentRoot;

        public TreeNode IncreasingBST(TreeNode root)
        {
            var dummy = new TreeNode(-1);
            currentRoot = dummy;

            InOrder(root);
            return dummy.right;
        }

        private void InOrder(TreeNode node)
        {
            if (node == null) return;

            InOrder(node.left);

            node.left = null;
            currentRoot.right = node;
            currentRoot = node;

            InOrder(node.right);
        }
    }
}
