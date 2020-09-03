//-----------------------------------------------------------------------------
// Runtime: 32ms
// Memory Usage: 14.5 MB
// Link: https://leetcode.com/submissions/detail/334548152/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1009_ComplementOfBase10Integer
    {
        public int BitwiseComplement(int N)
        {
            int mask = 1;
            while (mask < N)
                mask = (mask << 1) | 1;
            return N ^ mask;

        }
    }
}
