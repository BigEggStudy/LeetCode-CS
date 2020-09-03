//-----------------------------------------------------------------------------
// Runtime: 280ms
// Memory Usage: 29.7 MB
// Link: https://leetcode.com/submissions/detail/369513686/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _094_BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            InorderTraversal(root, result);
            return result;
        }

        public void InorderTraversal(TreeNode node, IList<int> result)
        {
            if (node == null) return;

            InorderTraversal(node.left, result);
            result.Add(node.val);
            InorderTraversal(node.right, result);
        }
    }
}
