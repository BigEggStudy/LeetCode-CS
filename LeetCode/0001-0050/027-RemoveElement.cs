//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 30.1 MB
// Link: https://leetcode.com/submissions/detail/351897187/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _027_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            var lastIndex = nums.Length - 1;

            for (int i = 0; i <= lastIndex; i++)
            {
                if (nums[i] == val)
                {
                    nums[i--] = nums[lastIndex--];
                }
            }

            return lastIndex + 1;
        }
    }
}
