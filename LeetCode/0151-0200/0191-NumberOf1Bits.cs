//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 14.7 MB
// Link: https://leetcode.com/submissions/detail/335030341/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0191_NumberOf1Bits
    {
        public int HammingWeight(uint n)
        {
            var num = 0;
            while (n > 0)
            {
                n &= n - 1;
                num++;
            }

            return num;
        }
    }
}
