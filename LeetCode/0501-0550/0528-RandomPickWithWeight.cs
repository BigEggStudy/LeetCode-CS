//-----------------------------------------------------------------------------
// Runtime: 208ms
// Memory Usage: 47.4 MB
// Link: https://leetcode.com/submissions/detail/379087578/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0528_RandomPickWithWeight
    {
        private readonly int[] prefixSums;
        private readonly int totalSum;
        private readonly Random random;

        public _0528_RandomPickWithWeight(int[] w)
        {
            prefixSums = new int[w.Length];
            for (int i = 0; i < w.Length; i++)
            {
                totalSum += w[i];
                prefixSums[i] = totalSum;
            }
            random = new Random();
        }

        public int PickIndex()
        {
            var target = random.Next(totalSum) + 1;

            int lo = 0, hi = prefixSums.Length - 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (target == prefixSums[mid]) return mid;
                if (target > prefixSums[mid])
                    lo = mid + 1;
                else
                    hi = mid - 1;
            }

            return lo;
        }
    }

    /**
     * Your Solution object will be instantiated and called as such:
     * Solution obj = new Solution(w);
     * int param_1 = obj.PickIndex();
     */
}
