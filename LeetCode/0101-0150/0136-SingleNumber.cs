//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 25.2 MB
// Link: https://leetcode.com/submissions/detail/261543230/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0136_SingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            var a = 0;
            foreach (var num in nums)
                a ^= num;

            return a;
        }
    }
}
