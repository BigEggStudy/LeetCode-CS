//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 13.7 MB
// Link: https://leetcode.com/submissions/detail/261549862/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0371_SumOfTwoIntegers
    {
        public int GetSum(int a, int b)
        {
            return b == 0 ? a : GetSum(a ^ b, (a & b) << 1);
        }
    }
}
