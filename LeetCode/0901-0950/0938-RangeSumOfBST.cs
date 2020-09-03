//-----------------------------------------------------------------------------
// Runtime: 172ms
// Memory Usage: 44.3 MB
// Link: https://leetcode.com/submissions/detail/378634468/
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
    public class _0938_RangeSumOfBST
    {
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            if (root == null)
                return 0;
            else if (root.val < L)
                return RangeSumBST(root.right, L, R);
            else if (root.val > R)
                return RangeSumBST(root.left, L, R);
            else
                return root.val + RangeSumBST(root.left, L, R) + RangeSumBST(root.right, L, R);
        }
    }
}
