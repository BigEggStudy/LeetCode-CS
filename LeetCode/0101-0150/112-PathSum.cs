//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 26 MB
// Link: https://leetcode.com/submissions/detail/352942498/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _112_PathSum
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;

            sum = sum - root.val;
            if (root.left == null && root.right == null) return sum == 0;
            return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);
        }
    }
}
