//-----------------------------------------------------------------------------
// Runtime: 288ms
// Memory Usage: 31.1 MB
// Link: https://leetcode.com/submissions/detail/367606994/
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
    public class _0314_BinaryTreeVerticalOrderTraversal
    {
        public IList<IList<int>> VerticalOrder(TreeNode root)
        {
            var results = new List<IList<int>>();
            if (root == null) return results;

            var columnTable = new Dictionary<int, IList<int>>();
            var queue = new Queue<(int col, TreeNode node)>();
            queue.Enqueue((0, root));

            int minColumn = 0, maxColumn = 0;
            while (queue.Count > 0)
            {
                (int col, TreeNode node) = queue.Dequeue();

                if (!columnTable.ContainsKey(col))
                    columnTable[col] = new List<int>();
                columnTable[col].Add(node.val);
                minColumn = Math.Min(minColumn, col);
                maxColumn = Math.Max(maxColumn, col);

                if (node.left != null)
                    queue.Enqueue((col - 1, node.left));
                if (node.right != null)
                    queue.Enqueue((col + 1, node.right));
            }

            for (int i = minColumn; i < maxColumn + 1; ++i)
                results.Add(columnTable[i]);

            return results;
        }
    }
}
