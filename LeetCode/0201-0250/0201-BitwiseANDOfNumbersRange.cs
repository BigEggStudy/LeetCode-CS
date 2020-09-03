//-----------------------------------------------------------------------------
// Runtime: 48ms
// Memory Usage: 15.6 MB
// Link: https://leetcode.com/submissions/detail/329230476/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0201_BitwiseANDOfNumbersRange
    {
        public int RangeBitwiseAnd(int m, int n)
        {
            while (m < n)
                n = n & (n - 1);

            return m & n;
        }
    }
}
