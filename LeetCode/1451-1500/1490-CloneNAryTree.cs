//-----------------------------------------------------------------------------
// Runtime: 420ms
// Memory Usage: 51.1 MB
// Link: https://leetcode.com/submissions/detail/360349158/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    /*
    // Definition for a Node.
    public class Node {
        public int val;
        public IList<Node> children;
    
        public Node() {
            val = 0;
            children = new List<Node>();
        }
    
        public Node(int _val) {
            val = _val;
            children = new List<Node>();
        }
    
        public Node(int _val, List<Node> _children) {
            val = _val;
            children = _children;
        }
    }
    */


    public class _1490_CloneNAryTree
    {
        public Node CloneTree(Node root)
        {
            if (root == null) return null;

            var newRoot = new Node(root.val);
            foreach (var child in root.children)
                newRoot.children.Add(CloneTree(child));

            return newRoot;
        }

        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node()
            {
                val = 0;
                children = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                children = new List<Node>();
            }

            public Node(int _val, List<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }
    }
}
