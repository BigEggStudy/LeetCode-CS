//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 25.5 MB
// Link: https://leetcode.com/submissions/detail/365312460/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0994_RottingOranges
    {
        public int OrangesRotting(int[][] grid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;

            var queue = new Queue<(int r, int c)>();
            var freshCount = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 2) queue.Enqueue((i, j));
                    else if (grid[i][j] == 1) freshCount++;
                }

            if (freshCount == 0) return 0;

            var directions = new (int d_row, int d_col)[4] { (0, 1), (1, 0), (0, -1), (-1, 0) };
            var time = 0;
            while (queue.Count > 0)
            {
                time++;
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    (int row, int col) = queue.Dequeue();
                    foreach ((int d_row, int d_col) in directions)
                    {
                        var neighborRow = row + d_row;
                        var neighborCol = col + d_col;
                        if (neighborRow >= 0 && neighborRow < rows &&
                            neighborCol >= 0 && neighborCol < cols)
                        {
                            if (grid[neighborRow][neighborCol] == 1)
                            {
                                grid[neighborRow][neighborCol] = 2;
                                freshCount--;
                                queue.Enqueue((neighborRow, neighborCol));
                            }
                        }
                    }
                }

                if (freshCount == 0) break;
            }

            return freshCount == 0 ? time : -1;
        }
    }
}
