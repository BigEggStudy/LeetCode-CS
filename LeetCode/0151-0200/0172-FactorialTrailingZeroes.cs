//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.6 MB
// Link: https://leetcode.com/submissions/detail/358360122/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0172_FactorialTrailingZeroes
    {
        public int TrailingZeroes(int n)
        {
            var count = 0;
            while (n > 0)
            {
                n /= 5;
                count += n;
            }

            return count;
        }
    }
}
