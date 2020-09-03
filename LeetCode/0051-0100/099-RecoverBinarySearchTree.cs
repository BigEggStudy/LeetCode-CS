//-----------------------------------------------------------------------------
// Runtime: 140ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _099_RecoverBinarySearchTree
    {
        private Stack<TreeNode> stack = new Stack<TreeNode>();
        private TreeNode prev = null;
        private TreeNode first = null;
        private TreeNode second = null;
        private TreeNode current = null;

        public void RecoverTree(TreeNode root)
        {
            current = root;
            while (stack.Count > 0 || current != null)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                current = stack.Pop();
                if (prev != null && current.val < prev.val)
                {
                    if (first == null) first = prev;
                    second = current;
                }
                if (first != null && first.val < current.val) break;

                prev = current;
                current = current.right;
            }

            var temp = first.val;
            first.val = second.val;
            second.val = temp;
        }
    }
}
