//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25 MB
// Link: https://leetcode.com/submissions/detail/379065640/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    /*
    // Definition for a Node.
    public class Node {
        public int val;
        public Node next;
        public Node random;

        public Node(){}
        public Node(int _val,Node _next,Node _random) {
            val = _val;
            next = _next;
            random = _random;
    }
    */
    public class _0138_CopyListWithRandomPointer
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;
            var map = new Dictionary<Node, Node>();
            var curr = head;
            while (curr != null)
            {
                var clone = CloneNode(curr, map);
                clone.next = CloneNode(curr.next, map);
                clone.random = CloneNode(curr.random, map);

                curr = curr.next;
            }
            return map[head];
        }

        private Node CloneNode(Node node, IDictionary<Node, Node> map)
        {
            if (node == null) return null;
            if (map.ContainsKey(node)) return map[node];

            var clone = new Node(node.val);
            map[node] = clone;
            return clone;
        }

        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _next, Node _random)
            {
                val = _val;
                next = _next;
                random = _random;
            }
        }
    }
}
