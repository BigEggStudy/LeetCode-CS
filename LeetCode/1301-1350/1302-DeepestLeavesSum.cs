//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 35.3 MB
// Link: https://leetcode.com/submissions/detail/360396244/
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
    public class _1302_DeepestLeavesSum
    {
        public int DeepestLeavesSum(TreeNode root)
        {
            var prevLevel = new List<TreeNode>();
            var currLevel = new List<TreeNode>();

            prevLevel.Add(root);
            while (true)
            {
                foreach (var node in prevLevel)
                {
                    if (node.left != null) currLevel.Add(node.left);
                    if (node.right != null) currLevel.Add(node.right);
                }

                if (currLevel.Count == 0) break;

                prevLevel = currLevel;
                currLevel = new List<TreeNode>();
            }

            var sum = 0;
            foreach (var node in prevLevel)
                sum += node.val;

            return sum;
        }
    }
}
