//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 24.9 MB
// Link: https://leetcode.com/submissions/detail/357933065/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0137_SingleNumberII
    {
        public int SingleNumber(int[] nums)
        {
            int seenOnce = 0, seenTwice = 0;

            foreach (int num in nums)
            {
                seenOnce = ~seenTwice & (seenOnce ^ num);
                seenTwice = ~seenOnce & (seenTwice ^ num);
            }

            return seenOnce;
        }
    }
}
