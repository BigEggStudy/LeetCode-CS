//-----------------------------------------------------------------------------
// Runtime: 44ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1197_MinimumKnightMoves
    {
        public int MinKnightMoves(int x, int y)
        {
            var dp = new int[301, 301];
            dp[0, 0] = 0;
            dp[1, 2] = dp[2, 1] = 1;
            dp[0, 2] = dp[2, 0] = dp[1, 1] = 2;
            return DP(dp, Math.Abs(x), Math.Abs(y));
        }

        public int DP(int[,] dp, int x, int y)
        {
            if (x == 0 && y == 0) return 0;
            if ((x == 1 && y == 2) || (x == 2 && y == 1)) return 1;
            if (dp[x, y] > 0) return dp[x, y];

            var result = Math.Min(DP(dp, Math.Abs(x - 1), Math.Abs(y - 2)), DP(dp, Math.Abs(x - 2), Math.Abs(y - 1))) + 1;
            dp[x, y] = result;
            return result;
        }
    }
}
