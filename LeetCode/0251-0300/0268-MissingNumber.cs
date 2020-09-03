//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 29.9 MB
// Link: https://leetcode.com/submissions/detail/380050584/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0268_MissingNumber
    {
        public int MissingNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; ++i)
                result += (i + 1) - nums[i];
            return result;
        }
    }
}
