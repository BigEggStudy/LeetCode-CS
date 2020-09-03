//-----------------------------------------------------------------------------
// Runtime: 124ms
// Memory Usage: 30 MB
// Link: https://leetcode.com/submissions/detail/368912698/
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
    public class _0742_ClosestLeafInABinaryTree
    {
        public int FindClosestLeaf(TreeNode root, int k)
        {
            var graph = new Dictionary<TreeNode, IList<TreeNode>>();
            BuildGraph(graph, null, root);

            var queue = new Queue<TreeNode>();
            var seen = new HashSet<TreeNode>();
            foreach (var node in graph.Keys)
            {
                if (node.val == k)
                {
                    queue.Enqueue(node);
                    seen.Add(node);
                    break;
                }
            }

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node == null) continue;
                if (graph[node].Count <= 1) return node.val;
                foreach (var next in graph[node])
                {
                    if (!seen.Contains(next))
                    {
                        seen.Add(next);
                        queue.Enqueue(next);
                    }
                }
            }

            return -1;
        }

        private void BuildGraph(Dictionary<TreeNode, IList<TreeNode>> graph, TreeNode parent, TreeNode node)
        {
            if (node == null) return;
            if (parent != null)
            {
                if (!graph.ContainsKey(parent)) graph[parent] = new List<TreeNode>();
                graph[parent].Add(node);
            }

            if (!graph.ContainsKey(node)) graph[node] = new List<TreeNode>();
            graph[node].Add(parent);

            BuildGraph(graph, node, node.left);
            BuildGraph(graph, node, node.right);
        }
    }
}
