//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.6 MB
// Link: https://leetcode.com/submissions/detail/337432441/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0693_BinaryNumberWithAlternatingBits
    {
        public bool HasAlternatingBits(int n)
        {
            var prev = n & 1;
            n >>= 1;
            while (n > 0)
            {
                var current = n & 1;
                if (current == prev) return false;
                prev = current;
                n >>= 1;
            }
            return true;
        }
    }
}
