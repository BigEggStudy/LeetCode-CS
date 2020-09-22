//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 33.9 MB
// Link: https://leetcode.com/submissions/detail/399382535/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /*
    // Definition for a Node.
    public class Node {
        public int val;
        public Node left;
        public Node right;
        public Node parent;
    }
    */

    public class _0510_InorderSuccessorInBSTII
    {
        public Node InorderSuccessor(Node x)
        {
            if (x.right != null)
            {
                x = x.right;
                while (x.left != null)
                    x = x.left;
                return x;
            }

            while (x.parent != null && x == x.parent.right)
                x = x.parent;
            return x.parent;
        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node parent;
        }
    }
}
