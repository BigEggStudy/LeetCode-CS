//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 28.1 MB
// Link: https://leetcode.com/submissions/detail/342499617/
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
    public class _0230_KthSmallestElementInABST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            var list = new List<int>();
            InOrder(root, k, list);
            return list[k - 1];
        }

        public void InOrder(TreeNode node, int k, IList<int> values)
        {
            if (values.Count >= k) return;
            if (node == null) return;

            InOrder(node.left, k, values);
            values.Add(node.val);
            InOrder(node.right, k, values);
        }
    }
}
