//-----------------------------------------------------------------------------
// Runtime: 252ms
// Memory Usage: 45.3 MB
// Link: https://leetcode.com/submissions/detail/360429492/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    /**
     * Definition for Node.
     * public class Node {
     *     public int val;
     *     public Node left;
     *     public Node right;
     *     public Node random;
     *     public Node(int val=0, Node left=null, Node right=null, Node random=null) {
     *         this.val = val;
     *         this.left = left;
     *         this.right = right;
     *         this.random = random;
     *     }
     * }
     */

    public class _1485_CloneBinaryTreeWithRandomPointer
    {
        public NodeCopy CopyRandomBinaryTree(Node root)
        {
            var map = new Dictionary<Node, NodeCopy>();
            return CopyRandomBinaryTree(root, map);
        }

        private NodeCopy CopyRandomBinaryTree(Node node, Dictionary<Node, NodeCopy> map)
        {
            if (node == null) return null;
            if (map.ContainsKey(node)) return map[node];

            var newNode = new NodeCopy(node.val);

            map.Add(node, newNode);

            newNode.left = CopyRandomBinaryTree(node.left, map);
            newNode.right = CopyRandomBinaryTree(node.right, map);
            newNode.random = CopyRandomBinaryTree(node.random, map);

            return newNode;
        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node random;
            public Node(int val = 0, Node left = null, Node right = null, Node random = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
                this.random = random;
            }
        }

        public class NodeCopy
        {
            public int val;
            public NodeCopy left;
            public NodeCopy right;
            public NodeCopy random;
            public NodeCopy(int val = 0, NodeCopy left = null, NodeCopy right = null, NodeCopy random = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
                this.random = random;
            }
        }
    }
}
