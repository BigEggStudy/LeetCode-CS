//-----------------------------------------------------------------------------
// Runtime: 248ms
// Memory Usage: 30.9 MB
// Link: https://leetcode.com/submissions/detail/380534574/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0133_CloneGraph
    {
        public Node CloneGraph(Node node)
        {
            var map = new Dictionary<int, Node>();
            return CloneGraph(node, map);
        }

        public Node CloneGraph(Node node, IDictionary<int, Node> map)
        {
            if (node == null) return null;
            if (map.ContainsKey(node.val)) return map[node.val];

            var newNode = new Node(node.val, new List<Node>());
            map.Add(node.val, newNode);
            foreach (var child in node.neighbors)
                newNode.neighbors.Add(CloneGraph(child, map));

            return newNode;
        }

        public class Node
        {
            public int val;
            public IList<Node> neighbors;

            public Node() { }

            public Node(int _val, IList<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }
    }
}
