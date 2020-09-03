//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 30.8 MB
// Link: https://leetcode.com/submissions/detail/358263097/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1480_RunningSumOf1DArray
    {
        public int[] RunningSum(int[] nums)
        {
            var sum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
                nums[i] = sum;
            }

            return nums;
        }
    }
}
