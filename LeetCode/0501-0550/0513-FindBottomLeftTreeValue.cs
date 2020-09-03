//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 26.3 MB
// Link: https://leetcode.com/submissions/detail/370316414/
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
    public class _0513_FindBottomLeftTreeValue
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var result = 0;
            while (queue.Count > 0)
            {
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    if (i == 0) result = node.val;

                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
            }

            return result;
        }
    }
}
