//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 30 MB
// Link: https://leetcode.com/submissions/detail/389116382/
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
    public class _0450_DeleteNodeInABST
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null) return null;

            if (key > root.val) root.right = DeleteNode(root.right, key);
            else if (key < root.val) root.left = DeleteNode(root.left, key);
            else
            {
                if (root.left == null && root.right == null)
                    return null;
                else if (root.right != null)
                {
                    root.val = GetSuccessor(root);
                    root.right = DeleteNode(root.right, root.val);
                }
                else
                {
                    root.val = GetPredecessor(root);
                    root.left = DeleteNode(root.left, root.val);
                }
            }

            return root;
        }

        private int GetSuccessor(TreeNode node)
        {
            node = node.right;
            while (node.left != null)
                node = node.left;

            return node.val;
        }

        private int GetPredecessor(TreeNode node)
        {
            node = node.left;
            while (node.right != null)
                node = node.right;

            return node.val;
        }
    }
}
