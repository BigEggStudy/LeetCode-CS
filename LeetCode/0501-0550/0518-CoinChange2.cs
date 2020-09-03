//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 23.7 MB
// Link: https://leetcode.com/submissions/detail/350512612/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0518_CoinChange2
    {
        public int Change(int amount, int[] coins)
        {
            var dp = new int[amount + 1];
            dp[0] = 1;

            foreach (var coin in coins)
                for (int x = coin; x <= amount; x++)
                    dp[x] += dp[x - coin];

            return dp[amount];
        }
    }
}
