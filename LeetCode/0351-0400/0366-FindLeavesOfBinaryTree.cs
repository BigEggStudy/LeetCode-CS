//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 30.2 MB
// Link: https://leetcode.com/submissions/detail/361289301/
//-----------------------------------------------------------------------------

using System;
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
    public class _0366_FindLeavesOfBinaryTree
    {
        private List<IList<int>> results;

        public IList<IList<int>> FindLeaves(TreeNode root)
        {
            results = new List<IList<int>>();
            Helper(root);

            return results;
        }

        private int Helper(TreeNode root)
        {
            if (root == null) return 0;

            var leftLevel = Helper(root.left);
            var rightLevel = Helper(root.right);
            var currentLevel = Math.Max(leftLevel, rightLevel);

            if (results.Count == currentLevel)
                results.Add(new List<int>());
            results[currentLevel].Add(root.val);

            root.left = root.right = null;
            return currentLevel + 1;
        }
    }
}
