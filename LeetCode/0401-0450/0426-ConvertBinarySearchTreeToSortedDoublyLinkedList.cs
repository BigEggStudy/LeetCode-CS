//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 25 MB
// Link: https://leetcode.com/submissions/detail/368928169/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /*
    // Definition for a Node.
    public class Node {
        public int val;
        public Node left;
        public Node right;
    
        public Node() {}
    
        public Node(int _val) {
            val = _val;
            left = null;
            right = null;
        }
    
        public Node(int _val,Node _left,Node _right) {
            val = _val;
            left = _left;
            right = _right;
        }
    }
    */

    public class _0426_ConvertBinarySearchTreeToSortedDoublyLinkedList
    {
        private Node first;
        private Node last;

        public Node TreeToDoublyList(Node root)
        {
            if (root == null) return null;

            Helper(root);

            first.left = last;
            last.right = first;
            return first;
        }

        private void Helper(Node node)
        {
            if (node == null) return;

            Helper(node.left);

            if (last != null)
            {
                last.right = node;
                node.left = last;
            }
            else
            {
                first = node;
            }
            last = node;

            Helper(node.right);
        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
                left = null;
                right = null;
            }

            public Node(int _val, Node _left, Node _right)
            {
                val = _val;
                left = _left;
                right = _right;
            }
        }
    }
}
