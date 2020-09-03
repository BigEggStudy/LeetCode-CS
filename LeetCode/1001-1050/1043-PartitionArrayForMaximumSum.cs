//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 23.9 MB
// Link: https://leetcode.com/submissions/detail/263737774/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1043_PartitionArrayForMaximumSum
    {
        public int MaxSumAfterPartitioning(int[] A, int K)
        {
            int N = A.Length;
            var dp = new int[N];
            for (int i = 0; i < N; i++)
            {
                var currMax = A[i];
                for (int k = 1; k <= K && i - k + 1 >= 0; k++)
                {
                    currMax = Math.Max(currMax, A[i - k + 1]);
                    dp[i] = Math.Max(dp[i], (i >= k ? dp[i - k] : 0) + currMax * k);
                }
            }

            return dp[N - 1];
        }
    }
}
