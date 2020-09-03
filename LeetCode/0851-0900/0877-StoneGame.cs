//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.1 MB
// Link: https://leetcode.com/submissions/detail/364462771/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0877_StoneGame
    {
        public bool StoneGame(int[] piles)
        {
            int[] dp = new int[piles.Length];
            Array.Copy(piles, dp, piles.Length);

            for (int d = 1; d < piles.Length; d++)
                for (int i = 0; i < piles.Length - d; i++)
                    dp[i] = Math.Max(piles[i] - dp[i + 1], piles[i + d] - dp[i]);
            return dp[0] > 0;
        }
    }
}
