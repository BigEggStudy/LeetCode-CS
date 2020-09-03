//-----------------------------------------------------------------------------
// Runtime: 252ms
// Memory Usage: 33.7 MB
// Link: https://leetcode.com/submissions/detail/351039797/
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
    public class _1469_FindAllTheLonelyNodes
    {
        public IList<int> GetLonelyNodes(TreeNode root)
        {
            var results = new List<int>();
            GetLonelyNodes(root, results);

            return results;
        }

        private void GetLonelyNodes(TreeNode node, IList<int> results)
        {
            if (node.left == null && node.right == null) return;

            if (node.left != null)
            {
                if (node.right == null)
                    results.Add(node.left.val);
                GetLonelyNodes(node.left, results);
            }
            if (node.right != null)
            {
                if (node.left == null)
                    results.Add(node.right.val);
                GetLonelyNodes(node.right, results);
            }
        }
    }
}
