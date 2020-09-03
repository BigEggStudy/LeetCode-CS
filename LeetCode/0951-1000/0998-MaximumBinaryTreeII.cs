//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.6 MB
// Link: https://leetcode.com/submissions/detail/369912954/
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
    public class _0998_MaximumBinaryTreeII
    {
        public TreeNode InsertIntoMaxTree(TreeNode root, int val)
        {
            var newNode = new TreeNode(val);
            TreeNode prev = null, curr = root;

            while (curr != null && curr.val > newNode.val)
            {
                prev = curr;
                curr = curr.right;
            }

            if (prev != null)
                prev.right = newNode;
            else
                root = newNode;

            if (curr != null)
                newNode.left = curr;

            return root;
        }
    }
}
