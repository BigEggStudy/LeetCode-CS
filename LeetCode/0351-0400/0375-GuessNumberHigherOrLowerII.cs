//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0375_GuessNumberHigherOrLowerII
    {
        public int GetMoneyAmount(int n)
        {
            var dp = new int[n + 1, n + 1];

            for (int len = 2; len <= n; len++)
                for (int start = 1; start <= n - len + 1; start++)
                {
                    var result = int.MaxValue;
                    for (int piv = start + (len - 1) / 2; piv < start + len - 1; piv++)
                    {
                        var value = piv + Math.Max(dp[start, piv - 1], dp[piv + 1, start + len - 1]);
                        result = Math.Min(result, value);
                    }
                    dp[start, start + len - 1] = result;
                }

            return dp[1, n];
        }
    }
}
