//-----------------------------------------------------------------------------
// Runtime: 104,s
// Memory Usage: 26.4 MB
// Link: https://leetcode.com/submissions/detail/352343867/
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
    public class _0437_PathSumIII
    {
        public int result;

        public int PathSum(TreeNode root, int sum)
        {
            if (root == null) return 0;

            Dictionary<int, int> cache = new Dictionary<int, int>() { { 0, 1 } };
            DFS(root, sum, 0, cache);

            return result;
        }

        public void DFS(TreeNode root, int target, int currPathSum, Dictionary<int, int> cache)
        {
            if (root == null) return;

            currPathSum += root.val;
            int oldPathSum = currPathSum - target;
            if (cache.ContainsKey(oldPathSum)) result += cache[oldPathSum];

            if (!cache.ContainsKey(currPathSum))
                cache.Add(currPathSum, 0);
            cache[currPathSum]++;

            DFS(root.left, target, currPathSum, cache);
            DFS(root.right, target, currPathSum, cache);
            cache[currPathSum] -= 1;
        }
    }
}
