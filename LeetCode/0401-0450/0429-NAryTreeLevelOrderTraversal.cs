//-----------------------------------------------------------------------------
// Runtime: 296ms
// Memory Usage: 34.5 MB
// Link: https://leetcode.com/submissions/detail/364462426/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

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

    public class _0429_NAryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            var results = new List<IList<int>>();
            if (root == null) return results;

            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var size = queue.Count;
                var result = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    result.Add(node.val);
                    if (node.children != null)
                        foreach (var child in node.children)
                            queue.Enqueue(child);
                }

                results.Add(result);
            }

            return results;
        }

        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }
    }
}
