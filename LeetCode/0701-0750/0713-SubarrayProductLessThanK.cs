//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 44.7 MB
// Link: https://leetcode.com/submissions/detail/401960411/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0713_SubarrayProductLessThanK
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (k <= 1) return 0;

            int prod = 1, result = 0, left = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                prod *= nums[right];
                while (prod >= k)
                    prod /= nums[left++];
                result += right - left + 1;
            }

            return result;
        }
    }
}
