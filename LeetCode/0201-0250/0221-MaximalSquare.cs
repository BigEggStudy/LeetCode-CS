//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 29 MB
// Link: https://leetcode.com/submissions/detail/331198636/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0221_MaximalSquare
    {
        public int MaximalSquare(char[][] matrix)
        {
            var row = matrix.Length;
            if (row == 0) return 0;
            var col = matrix[0].Length;
            if (col == 0) return 0;

            var dp = new int[col + 1];
            int prev = 0, max = 0;
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    var temp = dp[j + 1];
                    if (matrix[i][j] == '1')
                    {
                        dp[j + 1] = Math.Min(Math.Min(dp[j], prev), dp[j + 1]) + 1;
                        max = Math.Max(max, dp[j + 1]);
                    }
                    else
                        dp[j + 1] = 0;

                    prev = temp;
                }

            return max * max;
        }
    }
}
