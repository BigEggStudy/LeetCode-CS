//-----------------------------------------------------------------------------
// Runtime: 132ms
// Memory Usage: 36.1 MB
// Link: https://leetcode.com/submissions/detail/332559699/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
     *         this.val = val;
     *         this.left = left;
     *         this.right = right;
     *     }
     * }
     */
    public class _1430_CheckIfAStringIsAValidSequenceFromRootToLeavesPathInABinaryTree
    {
        public bool IsValidSequence(TreeNode root, int[] arr)
        {
            return IsValidSequence(root, arr, 0);
        }

        private bool IsValidSequence(TreeNode root, int[] arr, int currentIndex)
        {
            if (root == null && currentIndex < arr.Length) return false;
            if (root.val != arr[currentIndex]) return false;

            if (currentIndex == arr.Length - 1)
                return root.left == null && root.right == null;

            if (root.left != null && root.right != null)
                return IsValidSequence(root.left, arr, currentIndex + 1) || IsValidSequence(root.right, arr, currentIndex + 1);
            else if (root.left != null)
                return IsValidSequence(root.left, arr, currentIndex + 1);
            else if (root.right != null)
                return IsValidSequence(root.right, arr, currentIndex + 1);

            return false;
        }
    }
}
