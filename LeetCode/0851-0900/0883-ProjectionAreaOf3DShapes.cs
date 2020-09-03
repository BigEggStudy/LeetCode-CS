//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25.8 MB
// Link: https://leetcode.com/submissions/detail/330707333/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0883_ProjectionAreaOf3DShapes
    {
        public int ProjectionArea(int[][] grid)
        {
            var N = grid.Length;

            var result = 0;
            for (int i = 0; i < N; i++)
            {
                int bestRow = 0, bestCol = 0;
                for (int j = 0; j < N; j++)
                {
                    if (grid[i][j] > 0) result++;
                    bestRow = Math.Max(bestRow, grid[i][j]);
                    bestCol = Math.Max(bestCol, grid[j][i]);
                }
                result += bestRow + bestCol;
            }

            return result;
        }
    }
}
