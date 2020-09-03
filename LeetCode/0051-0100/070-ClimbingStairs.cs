//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.5 MB
// Link: https://leetcode.com/submissions/detail/352318308/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _070_ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            if (n < 4) { return n; }

            int x1 = 2, x2 = 3, temp;
            for (int i = 4; i <= n; i++)
            {
                temp = x1 + x2;
                x1 = x2;
                x2 = temp;
            }

            return x2;
        }
    }
}
