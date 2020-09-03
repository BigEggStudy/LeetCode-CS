//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.4 MB
// Link: https://leetcode.com/submissions/detail/367520457/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _041_FirstMissingPositive
    {
        public int FirstMissingPositive(int[] nums)
        {
            int i, temp;
            for (i = 0; i < nums.Length; i++)
            {
                temp = nums[i];
                while (temp > 0 && temp < nums.Length && nums[temp - 1] != temp)
                {
                    nums[i] = nums[temp - 1];
                    nums[temp - 1] = temp;
                    temp = nums[i];
                }
            }

            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1) { break; }
            }
            return i + 1;
        }
    }
}
