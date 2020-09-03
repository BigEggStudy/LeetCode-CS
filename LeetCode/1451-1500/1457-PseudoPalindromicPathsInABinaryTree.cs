//-----------------------------------------------------------------------------
// Runtime: 196ms
// Memory Usage: 45.9 MB
// Link: https://leetcode.com/submissions/detail/363095932/
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
    public class _1457_PseudoPalindromicPathsInABinaryTree
    {
        private int[] counts = new int[10];
        private int result = 0;

        public int PseudoPalindromicPaths(TreeNode root)
        {
            PreOrder(root);
            return result;
        }

        private void PreOrder(TreeNode root)
        {
            if (root == null) return;

            counts[root.val]++;

            if (root.left == null && root.right == null)
                result += IsPalindromicPath() ? 1 : 0;

            PreOrder(root.left);
            PreOrder(root.right);

            counts[root.val]--;
        }

        private bool IsPalindromicPath()
        {
            var odd = 0;
            foreach (var val in counts)
                odd += val % 2 == 1 ? 1 : 0;

            return odd <= 1;
        }
    }
}
