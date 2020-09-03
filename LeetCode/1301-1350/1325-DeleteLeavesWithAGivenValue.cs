//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 26.4 MB
// Link: https://leetcode.com/submissions/detail/361202358/
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
    public class _1325_DeleteLeavesWithAGivenValue
    {
        public TreeNode RemoveLeafNodes(TreeNode root, int target)
        {
            if (root == null) return root;

            root.left = RemoveLeafNodes(root.left, target);
            root.right = RemoveLeafNodes(root.right, target);

            if (root.left == null && root.right == null && root.val == target)
                return null;
            else
                return root;
        }
    }
}
