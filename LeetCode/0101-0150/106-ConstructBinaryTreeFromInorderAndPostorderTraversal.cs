//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 26.3 MB
// Link: https://leetcode.com/submissions/detail/372492608/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _106_ConstructBinaryTreeFromInorderAndPostorderTraversal
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if (inorder.Length == 0 || postorder.Length == 0) return null;
            return BuildTree(inorder, 0, inorder.Length, postorder, 0, postorder.Length);
        }

        private TreeNode BuildTree(int[] inorder, int inorderStart, int inorderEnd, int[] postorder, int postorderStart, int postorderEnd)
        {
            var root = new TreeNode(postorder[postorderEnd - 1]);

            var inorderIndex = inorderStart;
            for (; inorderIndex < inorderEnd; inorderIndex++)
                if (inorder[inorderIndex] == postorder[postorderEnd - 1])
                    break;

            var leftLength = inorderIndex - inorderStart;
            if (leftLength > 0)
                root.left = BuildTree(inorder, inorderStart, inorderIndex, postorder, postorderStart, postorderStart + leftLength);
            if (inorderEnd > inorderIndex + 1)
                root.right = BuildTree(inorder, inorderIndex + 1, inorderEnd, postorder, postorderStart + leftLength, postorderEnd - 1);

            return root;
        }
    }
}
