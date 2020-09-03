//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 26.2 MB
// Link: https://leetcode.com/submissions/detail/379103526/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _045_JumpGame2
    {
        public int Jump(int[] nums)
        {
            int maxRight = 0, currentRight = 0, count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > maxRight) { return 0; }
                if (i > currentRight)
                {
                    count++;
                    currentRight = maxRight;

                }
                if (i + nums[i] > maxRight) { maxRight = i + nums[i]; }
            }

            return count;
        }
    }
}
