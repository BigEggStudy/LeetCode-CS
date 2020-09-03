//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 30.9 MB
// Link: https://leetcode.com/submissions/detail/378620291/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

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
    public class _0987_VerticalOrderTraversalOfABinaryTree
    {
        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            var results = new List<IList<int>>();
            if (root == null) return results;

            var columnTable = new Dictionary<int, List<int>>();
            var queue = new Queue<(int col, TreeNode node)>();
            queue.Enqueue((0, root));

            while (queue.Count > 0)
            {
                var size = queue.Count;
                var levelColumnTable = new Dictionary<int, List<int>>();
                for (int i = 0; i < size; i++)
                {
                    (int col, TreeNode node) = queue.Dequeue();

                    if (!levelColumnTable.ContainsKey(col))
                        levelColumnTable[col] = new List<int>();
                    levelColumnTable[col].Add(node.val);

                    if (node.left != null)
                        queue.Enqueue((col - 1, node.left));
                    if (node.right != null)
                        queue.Enqueue((col + 1, node.right));
                }

                foreach (var pair in levelColumnTable)
                {
                    if (!columnTable.ContainsKey(pair.Key))
                        columnTable[pair.Key] = new List<int>();

                    columnTable[pair.Key].AddRange(pair.Value.OrderBy(a => a));
                }
            }

            var min = columnTable.Keys.Min();
            var max = columnTable.Keys.Max();
            for (int i = min; i <= max; i++)
                results.Add(columnTable[i]);

            return results;
        }
    }
}
