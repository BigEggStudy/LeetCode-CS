//-----------------------------------------------------------------------------
// Runtime: 272ms
// Memory Usage: 33.1 MB
// Link: https://leetcode.com/submissions/detail/335630588/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1260_Shift2DGrid
    {
        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            var row = grid.Length;
            var col = grid[0].Length;

            if (k % (row * col) == 0)
                return grid;

            var result = new int[row][];
            for (int i = 0; i < row; i++)
                result[i] = new int[col];

            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    var newCol = (j + k) % col;
                    var wrapRows = (j + k) / col;
                    var newRow = (i + wrapRows) % row;
                    result[newRow][newCol] = grid[i][j];
                }

            return result;
        }
    }
}
