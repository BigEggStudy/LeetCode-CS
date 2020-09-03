//-----------------------------------------------------------------------------
// Runtime: 108 ms
// Memory Usage: 30.2 MB
// Link: https://leetcode.com/submissions/detail/378116878/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0322_CoinChange
    {
        public int CoinChange(int[] coins, int amount)
        {
            var dp = new long[amount + 1];
            for (int i = 0; i <= amount; i++)
                dp[i] = int.MaxValue;
            dp[0] = 0;

            for (int i = 1; i <= amount; i++)
                foreach (var coin in coins)
                    if (coin <= i)
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);

            return dp[amount] > amount ? -1 : (int)dp[amount];
        }
    }
}
