//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 32 MB
// Link: https://leetcode.com/submissions/detail/359609707/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0665_NonDecreasingArray
    {
        public bool CheckPossibility(int[] nums)
        {
            var index = -1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    if (index != -1) return false;
                    else
                        index = i;
                }
            }

            return index == -1
                || index == 0
                || index == nums.Length - 2
                || (nums[index - 1] <= nums[index + 1] || nums[index] <= nums[index + 2]);
        }
    }
}
