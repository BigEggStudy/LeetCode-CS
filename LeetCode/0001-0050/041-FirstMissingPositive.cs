//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 25.2 MB
// Link: https://leetcode.com/submissions/detail/402791512/
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
