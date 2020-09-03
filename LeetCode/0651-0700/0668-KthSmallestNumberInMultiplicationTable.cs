//-----------------------------------------------------------------------------
// Runtime: 52ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0668_KthSmallestNumberInMultiplicationTable
    {
        public int FindKthNumber(int m, int n, int k)
        {
            int lo = 1, hi = m * n;

            while (lo < hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (!FindKthNumber(mid, m, n, k)) lo = mid + 1;
                else hi = mid;
            }

            return lo;
        }

        private bool FindKthNumber(int x, int m, int n, int k)
        {
            var count = 0;
            for (int i = 1; i <= m; i++)
            {
                count += Math.Min(n, x / i);
                if (count >= k) return true;
            }

            return false;
        }
    }
}
