//-----------------------------------------------------------------------------
// Runtime: 32ms
// Memory Usage: 14.7 MB
// Link: https://leetcode.com/submissions/detail/352931470/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0342_PowerOfFour
    {
        public bool IsPowerOfFour(int num)
        {
            return num > 0 && ((num & (num - 1)) == 0) && ((num & 0xaaaaaaaa) == 0);
        }
    }
}
