//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.5 MB
// Link: https://leetcode.com/submissions/detail/343714695/
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
    public class _0783_MinimumDistanceBetweenBSTNodes
    {
        private int answer;
        private int prev;

        public int MinDiffInBST(TreeNode root)
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
