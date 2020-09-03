//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 26.2 MB
// Link: https://leetcode.com/submissions/detail/330097809/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _055_JumpGame
    {
        public bool CanJump(int[] nums)
        {
            int maxRight = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > maxRight) { return false; }
                if (i + nums[i] > maxRight)
                    maxRight = i + nums[i];
                if (maxRight >= nums.Length - 1)
                    return true;
            }

            return false;
        }
    }
}
