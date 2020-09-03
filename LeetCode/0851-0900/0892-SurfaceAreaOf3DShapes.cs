//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25.8 MB
// Link: https://leetcode.com/submissions/detail/338608246/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0892_SurfaceAreaOf3DShapes
    {
        public int SurfaceArea(int[][] grid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;

            var result = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] > 0)
                    {
                        result += 2 + grid[i][j] * 4;
                        if (i > 0 && grid[i - 1][j] > 0)
                            result -= 2 * Math.Min(grid[i - 1][j], grid[i][j]);
                        if (j > 0 && grid[i][j - 1] > 0)
                            result -= 2 * Math.Min(grid[i][j - 1], grid[i][j]);
                    }
                }

            return result;
        }
    }
}
