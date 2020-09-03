//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.6 MB
// Link: https://leetcode.com/submissions/detail/331987349/
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
    public class _1022_SumOfRootToLeafBinaryNumbers
    {
        public int SumRootToLeaf(TreeNode root)
        {
            var sum = 0;
            Helper(root, 0, ref sum);
            return sum;
        }

        private void Helper(TreeNode node, int current, ref int sum)
        {
            if (node == null) return;

            current = current * 2 + node.val;
            if (node.left == null && node.right == null)
            {
                sum += current;
                return;
            }

            Helper(node.left, current, ref sum);
            Helper(node.right, current, ref sum);
        }
    }
}
