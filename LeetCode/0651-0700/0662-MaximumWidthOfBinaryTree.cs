//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 25.1 MB
// Link: https://leetcode.com/submissions/detail/364425328/
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
    public class _0662_MaximumWidthOfBinaryTree
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            return dfs(root, 0, 1, new Dictionary<int, int>(), new Dictionary<int, int>());
        }

        public int dfs(TreeNode root, int level, int order, IDictionary<int, int> start, IDictionary<int, int> end)
        {
            if (root == null) return 0;
            if (start.Count == level)
            {
                start[level] = order;
                end[level] = order;
            }
            else
                end[level] = order;

            int cur = end[level] - start[level] + 1;
            int left = dfs(root.left, level + 1, 2 * order, start, end);
            int right = dfs(root.right, level + 1, 2 * order + 1, start, end);
            return Math.Max(cur, Math.Max(left, right));
        }
    }
}
