//-----------------------------------------------------------------------------
// Runtime: 252ms
// Memory Usage: 33.6 MB
// Link: https://leetcode.com/submissions/detail/363109065/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

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
    public class _1110_DeleteNodesAndReturnForest
    {
        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            var set = new HashSet<int>(to_delete);
            var results = new List<TreeNode>();

            var dummyHead = new TreeNode(-1);
            dummyHead.left = root;
            DeleteRoot(root, dummyHead, set, results);

            if (dummyHead.left != null)
                results.Add(root);

            return results;
        }

        private void DeleteRoot(TreeNode node, TreeNode parent, HashSet<int> deleteSet, List<TreeNode> results)
        {
            if (node == null) return;
            DeleteRoot(node.left, node, deleteSet, results);
            DeleteRoot(node.right, node, deleteSet, results);

            if (deleteSet.Contains(node.val))
            {
                if (node.left != null) results.Add(node.left);
                if (node.right != null) results.Add(node.right);

                if (parent.left == node) parent.left = null;
                else if (parent.right == node) parent.right = null;

                deleteSet.Remove(node.val);
            }
        }
    }
}
