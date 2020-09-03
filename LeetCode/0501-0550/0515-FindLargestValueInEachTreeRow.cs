//-----------------------------------------------------------------------------
// Runtime: 248ms
// Memory Usage: 32.5 MB
// Link: https://leetcode.com/submissions/detail/371097460/
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
    public class _0515_FindLargestValueInEachTreeRow
    {
        public IList<int> LargestValues(TreeNode root)
        {
            if (root == null) return new List<int>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var result = new List<int>();
            while (queue.Count > 0)
            {
                var size = queue.Count;
                var max = int.MinValue;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    max = Math.Max(max, node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }

                result.Add(max);
            }

            return result;
        }
    }
}
