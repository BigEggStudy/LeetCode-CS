//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0279_PerfectSquares
    {
        public int NumSquares(int n)
        {
            var dp = new int[n + 1];
            dp[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                int j = 1, min = int.MaxValue;
                while (i - j * j >= 0)
                {
                    min = Math.Min(min, dp[i - j * j]);
                    j++;
                }
                dp[i] = min + 1;
            }

            return dp[n];
        }
    }
}
