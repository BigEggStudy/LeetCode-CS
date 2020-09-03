//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 33.7 MB
// Link: https://leetcode.com/submissions/detail/360408838/
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
    public class _1315_SumOfNodesWithEvenValuedGrandparent
    {
        public int SumEvenGrandparent(TreeNode root)
        {
            return SumEvenGrandparent(root, 1, 1);
        }

        private int SumEvenGrandparent(TreeNode node, int parentValue, int grandparentValue)
        {
            if (node == null) return 0;

            return SumEvenGrandparent(node.left, node.val, parentValue) + SumEvenGrandparent(node.right, node.val, parentValue)
                + (grandparentValue % 2 == 0 ? node.val : 0);
        }
    }
}
