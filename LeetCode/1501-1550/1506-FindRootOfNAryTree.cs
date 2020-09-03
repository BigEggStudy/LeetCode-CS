//-----------------------------------------------------------------------------
// Runtime: 352ms
// Memory Usage: 49.6 MB
// Link: https://leetcode.com/submissions/detail/368559375/
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

    public class _1506_FindRootOfNAryTree
    {
        public Node FindRoot(List<Node> tree)
        {
            var value = 0;
            foreach (var node in tree)
            {
                value ^= node.val;
                foreach (var child in node.children)
                {
                    value ^= child.val;
                }
            }

            foreach (var node in tree)
            {
                if (node.val == value) return node;
            }

            return null;
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
