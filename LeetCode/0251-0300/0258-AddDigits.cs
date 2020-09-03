//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 14.6 MB
// Link: https://leetcode.com/submissions/detail/340981660/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0258_AddDigits
    {
        public int AddDigits(int num)
        {
            if (num == 0) return 0;
            var result = num % 9;
            return result == 0 ? 9 : result;
        }
    }
}
