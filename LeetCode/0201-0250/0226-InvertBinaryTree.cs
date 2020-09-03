//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 22.9 MB
// Link: https://leetcode.com/submissions/detail/262168882/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0226_InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;

            var left = root.left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(left);

            return root;
        }
    }
}
