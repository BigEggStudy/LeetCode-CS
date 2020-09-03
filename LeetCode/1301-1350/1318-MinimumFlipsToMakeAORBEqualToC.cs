//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.6 MB
// Link: https://leetcode.com/submissions/detail/369934848/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1318_MinimumFlipsToMakeAORBEqualToC
    {
        public int MinFlips(int a, int b, int c)
        {
            var result = 0;
            while (a > 0 || b > 0 || c > 0)
            {
                int ai = a % 2, bi = b % 2, ci = c % 2;
                if (ci == 1 && ai + bi == 0)
                    result++;
                else if (ci == 0)
                    result += ai + bi;

                a /= 2;
                b /= 2;
                c /= 2;
            }

            return result;
        }
    }
}
