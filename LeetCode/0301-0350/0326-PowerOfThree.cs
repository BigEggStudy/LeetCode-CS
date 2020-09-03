//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 16.7 MB
// Link: https://leetcode.com/submissions/detail/352829690/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0326_PowerOfThree
    {
        public bool IsPowerOfThree(int n)
        {
            return n > 0 && 1162261467 % n == 0;
        }
    }
}
