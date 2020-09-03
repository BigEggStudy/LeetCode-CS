//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 33.1 MB
// Link: https://leetcode.com/submissions/detail/352843520/
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
    public class _0501_FindModeInBinarySearchTree
    {
        private List<int> result = new List<int>();
        private int count, modelCount, prevValue;

        public int[] FindMode(TreeNode root)
        {
            InOrder(root);
            return result.ToArray();
        }

        private void InOrder(TreeNode node)
        {
            if (node == null) return;

            InOrder(node.left);

            if (prevValue != node.val) count = 1;
            else count++;

            if (count > modelCount)
            {
                result.Clear();
                result.Add(node.val);
                modelCount = count;
            }
            else if (count == modelCount)
                result.Add(node.val);

            prevValue = node.val;
            InOrder(node.right);
        }
    }
}
