//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.4 MB
// Link: https://leetcode.com/submissions/detail/327815703/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int x) { val = x; }
     * }
     */
    public class _1008_ConstructBinarySearchTreeFromPreorderTraversal
    {
        private int[] preorder;
        private int index;

        public TreeNode BstFromPreorder(int[] preorder)
        {
            this.preorder = preorder;
            index = 0;

            return Build(int.MinValue, int.MaxValue);
        }

        private TreeNode Build(int minValue, int maxValue)
        {
            if (index >= preorder.Length) return null;

            var value = preorder[index];
            if (value < minValue || value > maxValue)
                return null;

            var root = new TreeNode(value);
            index++;

            root.left = Build(minValue, value);
            root.right = Build(value, maxValue);

            return root;
        }
    }
}
