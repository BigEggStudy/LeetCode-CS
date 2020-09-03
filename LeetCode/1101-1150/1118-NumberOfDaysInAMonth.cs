//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 14.6 MB
// Link: https://leetcode.com/submissions/detail/338640136/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1118_NumberOfDaysInAMonth
    {
        public int NumberOfDays(int Y, int M)
        {
            var days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            var result = days[M - 1];
            if ((Y % 400 == 0 || Y % 100 != 0 && Y % 4 == 0) && M == 2)
                result++;

            return result;
        }
    }
}
