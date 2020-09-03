//-----------------------------------------------------------------------------
// Runtime: 212ms
// Memory Usage: 44.7 MB
// Link: https://leetcode.com/submissions/detail/361218762/
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
    public class _1161_MaximumLevelSumOfABinaryTree
    {
        public int MaxLevelSum(TreeNode root)
        {
            var currentLevel = 1;
            int maxSum = int.MinValue, maxLevel = 1;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var sum = 0;
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    sum += node.val;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }

                if (sum > maxSum)
                {
                    maxLevel = currentLevel;
                    maxSum = sum;
                }

                currentLevel++;
            }

            return maxLevel;
        }
    }
}
