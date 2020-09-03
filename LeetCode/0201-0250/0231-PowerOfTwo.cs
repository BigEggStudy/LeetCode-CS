//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 14.5 MB
// Link: https://leetcode.com/submissions/detail/350927502/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0231_PowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n == 0) return false;
            long x = n;
            return (x & -x) == x;
        }
    }
}
