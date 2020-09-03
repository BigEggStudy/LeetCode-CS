//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 31.9 MB
// Link: https://leetcode.com/submissions/detail/366243160/
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
     *     public TreeNode(int x) { val = x; }
     * }
     */
    public class _0863_AllNodesDistanceKInBinaryTree
    {
        public IList<int> DistanceK(TreeNode root, TreeNode target, int K)
        {
            var connections = new Dictionary<TreeNode, IList<TreeNode>>();
            BuildGraph(null, root, connections);

            var seen = new HashSet<TreeNode>();
            var queue = new Queue<TreeNode>();
            seen.Add(target);
            queue.Enqueue(target);
            while (queue.Count > 0 && K > 0)
            {
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    if (!connections.ContainsKey(node)) continue;
                    foreach (var neighbor in connections[node])
                    {
                        if (!seen.Contains(neighbor))
                        {
                            seen.Add(neighbor);
                            queue.Enqueue(neighbor);
                        }
                    }
                }

                K--;
            }

            return queue.Select(node => node.val).ToList();
        }

        private void BuildGraph(TreeNode parent, TreeNode child, Dictionary<TreeNode, IList<TreeNode>> connection)
        {
            if (parent != null && child != null)
            {
                if (!connection.ContainsKey(parent))
                    connection[parent] = new List<TreeNode>();
                if (!connection.ContainsKey(child))
                    connection[child] = new List<TreeNode>();

                connection[parent].Add(child);
                connection[child].Add(parent);
            }

            if (child.left != null)
                BuildGraph(child, child.left, connection);
            if (child.right != null)
                BuildGraph(child, child.right, connection);
        }
    }
}
