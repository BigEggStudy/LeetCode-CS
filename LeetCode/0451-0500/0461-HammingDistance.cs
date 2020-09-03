//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 13.7 MB
// Link: https://leetcode.com/submissions/detail/261547622/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0461_HammingDistance
    {
        public int HammingDistance(int x, int y)
        {
            var xor = x ^ y;
            var count = 0;
            while (xor > 0)
            {
                if ((xor & 1) == 1) count++;
                xor >>= 1;
            }
            return count;
        }
    }
}
