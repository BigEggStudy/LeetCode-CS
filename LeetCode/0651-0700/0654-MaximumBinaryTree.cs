//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 28 MB
// Link: https://leetcode.com/submissions/detail/262177117/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0654_MaximumBinaryTree
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return ConstructMaximumBinaryTree(nums, 0, nums.Length);
        }

        private TreeNode ConstructMaximumBinaryTree(int[] nums, int left, int right)
        {
            if (left == right) return null;
            var maxIndex = GetMaxIndex(nums, left, right);

            var node = new TreeNode(nums[maxIndex]);
            node.left = ConstructMaximumBinaryTree(nums, left, maxIndex);
            node.right = ConstructMaximumBinaryTree(nums, maxIndex + 1, right);

            return node;
        }

        private int GetMaxIndex(int[] nums, int left, int right)
        {
            var result = left;
            for (int i = left; i < right; i++)
                if (nums[result] < nums[i]) result = i;

            return result;
        }
    }
}
