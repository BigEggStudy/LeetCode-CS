//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 24 MB
// Link: https://leetcode.com/submissions/detail/364458054/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1219_PathWithMaximumGold
    {
        public int GetMaximumGold(int[][] grid)
        {
            var count = 0;
            for (var i = 0; i < grid.Length; i++)
                for (var j = 0; j < grid[i].Length; j++)
                    if (grid[i][j] != 0) count = Math.Max(count, MaxGold(grid, i, j, 0));

            return count;
        }

        private int MaxGold(int[][] grid, int row, int col, int count)
        {
            if (row >= grid.Length || col >= grid[0].Length || row < 0 || col < 0) return count;
            if (grid[row][col] == 0) return count;

            count += grid[row][col];

            var temp = grid[row][col];
            grid[row][col] = 0;

            var left = MaxGold(grid, row - 1, col, count);
            var right = MaxGold(grid, row + 1, col, count);
            var top = MaxGold(grid, row, col - 1, count);
            var bottom = MaxGold(grid, row, col + 1, count);
            grid[row][col] = temp;

            return Math.Max(Math.Max(left, right), Math.Max(top, bottom));
        }
    }
}
