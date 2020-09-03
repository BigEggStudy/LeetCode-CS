//-----------------------------------------------------------------------------
// Runtime: 44ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0837_New21Game
    {
        public double New21Game(int N, int K, int W)
        {
            var dp = new double[N + W + 1];
            for (int k = K; k <= N; k++)
                dp[k] = 1.0;

            double S = Math.Min(W, N - K + 1);
            for (int k = K - 1; k >= 0; k--)
            {
                dp[k] = S / W;
                S += dp[k] - dp[k + W];
            }

            return dp[0];
        }
    }
}
