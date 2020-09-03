//-----------------------------------------------------------------------------
// Runtime: 292ms
// Memory Usage: 34.1 MB
// Link: https://leetcode.com/submissions/detail/328759241/
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

    public class _0589_NAryTreePreorderTraversal
    {
        public IList<int> Preorder(Node root)
        {
            var result = new List<int>();
            if (root == null) return result;

            var stack = new Stack<Node>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                result.Add(node.val);
                if (node.children != null)
                    for (int i = node.children.Count - 1; i >= 0; i--)
                        stack.Push(node.children[i]);
            }

            return result;
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
