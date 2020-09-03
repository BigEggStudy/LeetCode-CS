//-----------------------------------------------------------------------------
// Runtime: 408ms
// Memory Usage: 51.9 MB
// Link: https://leetcode.com/submissions/detail/378975764/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /*
    // Definition for a Node.
    public class Node {
        public int val;
        public IList<Node> children;
    
        public Node() {}
    
        public Node(int _val) {
            val = _val;
        }
    
        public Node(int _val, IList<Node> _children) {
            val = _val;
            children = _children;
        }
    }
    */

    public class _0428_SerializeAndDeserializeNAryTree
    {
        private readonly string SPLITTER = ",";
        private readonly string NULL = "null";

        // Encodes a tree to a single string.
        public string serialize(Node root)
        {
            if (root == null) return NULL;

            var dummy = new Node(-1, new List<Node>());
            dummy.children.Add(root);

            var queue = new Queue<Node>();
            queue.Enqueue(dummy);

            var sb = new StringBuilder();
            while (queue.Count > 0)
            {
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    foreach (var child in node.children)
                    {
                        sb.Append(child.val);
                        sb.Append(SPLITTER);
                        queue.Enqueue(child);
                    }
                    sb.Append(NULL);
                    sb.Append(SPLITTER);
                }
            }
            return sb.ToString();
        }

        // Decodes your encoded data to tree.
        public Node deserialize(string data)
        {
            var split = data.Split(new string[] { SPLITTER }, StringSplitOptions.RemoveEmptyEntries);
            if (split.Length == 1 && split[0] == NULL) return null;

            var dummy = new Node(-1, new List<Node>());
            var queue = new Queue<Node>();
            queue.Enqueue(dummy);
            foreach (var value in split)
            {
                if (value == NULL)
                {
                    queue.Dequeue();
                    continue;
                }
                var node = new Node(int.Parse(value), new List<Node>());
                queue.Peek().children.Add(node);
                queue.Enqueue(node);
            }
            return dummy.children[0];
        }

        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec codec = new Codec();
    // codec.deserialize(codec.serialize(root));
}
