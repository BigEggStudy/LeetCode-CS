//-----------------------------------------------------------------------------
// Runtime: 156ms
// Memory Usage: 40.4 MB
// Link: https://leetcode.com/submissions/detail/261196329/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0173_BinarySearchTreeIterator
    {
        private readonly Stack<TreeNode> stack;

        public _0173_BinarySearchTreeIterator(TreeNode root)
        {
            stack = new Stack<TreeNode>();
            LeftMostInorder(root);
        }

        private void LeftMostInorder(TreeNode root)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
        }

        /** @return the next smallest number */
        public int Next()
        {
            var node = stack.Pop();

            if (node.right != null)
                LeftMostInorder(node.right);

            return node.val;
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return stack.Count > 0;
        }
    }
}
