//-----------------------------------------------------------------------------
// Runtime: 128ms
// Memory Usage: 37.6 MB
// Link: https://leetcode.com/submissions/detail/408819393/
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
    public class _0701_InsertIntoABinarySearchTree
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null) return new TreeNode(val);

            var node = root;
            while (node != null)
            {
                if (val < node.val)
                {
                    if (node.left == null)
                    {
                        node.left = new TreeNode(val);
                        return root;
                    }
                    else
                        node = node.left;
                }
                else
                {
                    if (node.right == null)
                    {
                        node.right = new TreeNode(val);
                        return root;
                    }
                    else
                        node = node.right;
                }
            }

            return root;
        }
    }
}
