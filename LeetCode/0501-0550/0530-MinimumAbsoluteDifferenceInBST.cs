//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 28 MB
// Link: https://leetcode.com/submissions/detail/343715777/
//-----------------------------------------------------------------------------

using System;

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
    public class _0530_MinimumAbsoluteDifferenceInBST
    {
        private int answer;
        private int prev;

        public int GetMinimumDifference(TreeNode root)
        {
            answer = int.MaxValue;
            prev = int.MaxValue;
            DFS(root);
            return answer;
        }

        private void DFS(TreeNode node)
        {
            if (node == null) return;

            DFS(node.left);

            if (prev != int.MaxValue)
                answer = Math.Min(answer, node.val - prev);
            prev = node.val;

            DFS(node.right);
        }
    }
}
