//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.3 MB
// Link: https://leetcode.com/submissions/detail/336107118/
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
    public class _0993_CousinsInBinaryTree
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var size = queue.Count;
                bool siblings = false, cousins = false;

                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    if (node == null)
                        siblings = false;
                    else
                    {
                        if (node.val == x || node.val == y)
                            if (!cousins)
                                siblings = cousins = true;
                            else
                                return !siblings;

                        if (node.left != null) queue.Enqueue(node.left);
                        if (node.right != null) queue.Enqueue(node.right);
                    }
                    queue.Enqueue(null);
                }

                if (cousins) return false;
            }

            return false;
        }
    }
}
