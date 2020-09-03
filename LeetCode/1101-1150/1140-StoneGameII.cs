//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 23.6 MB
// Link: https://leetcode.com/submissions/detail/369527897/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1140_StoneGameII
    {
        public int StoneGameII(int[] piles)
        {
            var N = piles.Length;
            var sum = 0;
            var sums = new int[N];
            for (int i = N - 1; i >= 0; i--)
            {
                sum += piles[i];
                sums[i] = sum;
            }

            var dp = new int[N, N];
            return Play(piles, sums, dp, 0, 1);
        }

        private int Play(int[] piles, int[] sums, int[,] dp, int index, int M)
        {
            var N = piles.Length;
            if (index >= N) return 0;
            if (M * 2 >= N - index) return sums[index];
            if (dp[index, M] != 0) return dp[index, M];

            for (int i = 1; i <= Math.Min(N, 2 * M) && index + i < N; i++)
            {
                var taken = sums[index] - sums[index + i];
                var remain = sums[index + i] - Play(piles, sums, dp, index + i, Math.Max(M, i));
                dp[index, M] = Math.Max(dp[index, M], taken + remain);
            }

            return dp[index, M];
        }
    }
}
