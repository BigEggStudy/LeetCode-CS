//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 33.4 MB
// Link: https://leetcode.com/submissions/detail/335608120/
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
    public class _0637_AverageOfLevelsInBinaryTree
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var result = new List<double>();
            if (root == null) return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var levelCount = queue.Count;
                double sum = 0.0;
                for (int i = 0; i < levelCount; i++)
                {
                    var node = queue.Dequeue();
                    sum += node.val;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }

                result.Add(sum / levelCount);
            }

            return result;
        }
    }
}
