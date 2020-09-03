//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.6 MB
// Link: https://leetcode.com/submissions/detail/361228628/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1492_TheKthFactorOfN
    {
        public int KthFactor(int n, int k)
        {
            int d = 1;
            for (; d * d <= n; d++)
                if (n % d == 0 && --k == 0)
                    return d;
            for (d = d - 1; d >= 1; d--)
            {
                if (d * d == n) continue;
                if (n % d == 0 && --k == 0)
                    return n / d;
            }

            return -1;
        }
    }
}
