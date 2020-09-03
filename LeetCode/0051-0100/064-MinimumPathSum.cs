//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 26 MB
// Link: https://leetcode.com/submissions/detail/326831631/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _064_MinimumPathSum
    {
        public int MinPathSum(int[][] grid)
        {
            var rowLenght = grid.Length;
            var columnLenght = grid[0].Length;

            var pathSum = new int[columnLenght];
            for (int i = 0; i < columnLenght; i++)
                pathSum[i] = int.MaxValue;
            pathSum[0] = 0;

            for (int i = 0; i < rowLenght; i++)
            {
                pathSum[0] += grid[i][0];
                for (int j = 1; j < columnLenght; j++)
                    pathSum[j] = Math.Min(pathSum[j - 1], pathSum[j]) + grid[i][j];
            }

            return pathSum[columnLenght - 1];
        }
    }
}
