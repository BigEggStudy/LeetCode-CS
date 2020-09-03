//-----------------------------------------------------------------------------
// Runtime: 32ms
// Memory Usage: 14.5 MB
// Link: https://leetcode.com/submissions/detail/334546822/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0476_NumberComplement
    {
        public int FindComplement(int num)
        {
            int mask = 1;
            while (mask < num)
                mask = (mask << 1) | 1;
            return num ^ mask;
        }
    }
}
