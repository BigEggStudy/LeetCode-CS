//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 30.1 MB
// Link: https://leetcode.com/submissions/detail/342509501/
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
    public class _0653_TwoSumIVInputIsABST
    {
        public bool FindTarget(TreeNode root, int k)
        {
            var set = new HashSet<int>();
            return InOrder(root, k, set);
        }

        public bool InOrder(TreeNode node, int k, HashSet<int> set)
        {
            if (node == null) return false;
            if (set.Contains(k - node.val)) return true;

            set.Add(node.val);
            return InOrder(node.left, k, set) || InOrder(node.right, k, set);
        }
    }
}
