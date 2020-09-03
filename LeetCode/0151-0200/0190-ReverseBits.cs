//-----------------------------------------------------------------------------
// Runtime: 44ms
// Memory Usage: 15 MB
// Link: https://leetcode.com/submissions/detail/358731194/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0190_ReverseBits
    {
        public uint reverseBits(uint n)
        {
            n = (n >> 16) | (n << 16);
            n = ((n & 0xff00ff00) >> 8) | ((n & 0x00ff00ff) << 8);
            n = ((n & 0xf0f0f0f0) >> 4) | ((n & 0x0f0f0f0f) << 4);
            n = ((n & 0xcccccccc) >> 2) | ((n & 0x33333333) << 2);
            n = ((n & 0xaaaaaaaa) >> 1) | ((n & 0x55555555) << 1);
            return n;
        }
    }
}
