//-----------------------------------------------------------------------------
// Runtime: 408ms
// Memory Usage: 32.7 MB
// Link: https://leetcode.com/submissions/detail/330172558/
//-----------------------------------------------------------------------------

using System;
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

    public class _0559_MaximumDepthOfNAryTree
    {
        public int MaxDepth(Node root)
        {
            if (root == null) return 0;

            var max = 0;
            foreach (var child in root.children)
                max = Math.Max(max, MaxDepth(child));

            return max + 1;
        }

        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
                children = new List<Node>();
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }
    }
}
