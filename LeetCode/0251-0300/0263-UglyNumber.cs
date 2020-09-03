//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.7 MB
// Link: https://leetcode.com/submissions/detail/352933164/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0263_UglyNumber
    {
        public bool IsUgly(int num)
        {
            if (num <= 0) return false;

            while (num > 1 && (num % 2 == 0))
                num /= 2;
            while (num > 1 && (num % 3 == 0))
                num /= 3;
            while (num > 1 && (num % 5 == 0))
                num /= 5;

            return num == 1;
        }
    }
}
