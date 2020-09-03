//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _114_FlattenBinaryTreeToLinkedList
    {
        TreeNode prev = null;

        public void Flatten(TreeNode root)
        {
            if (root == null) return;

            Flatten(root.right);
            Flatten(root.left);

            root.right = prev;
            root.left = null;
            prev = root;
        }
    }
}
