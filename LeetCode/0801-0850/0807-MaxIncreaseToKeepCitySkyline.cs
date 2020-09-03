//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 25.7 MB
// Link: https://leetcode.com/submissions/detail/360406293/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0807_MaxIncreaseToKeepCitySkyline
    {
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            var N = grid.Length;

            var skylineRows = new int[N];
            var skylineCols = new int[N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    skylineRows[i] = Math.Max(skylineRows[i], grid[i][j]);
                    skylineCols[j] = Math.Max(skylineCols[j], grid[i][j]);
                }

            var result = 0;
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    result += Math.Min(skylineRows[i], skylineCols[j]) - grid[i][j];

            return result;
        }
    }
}
