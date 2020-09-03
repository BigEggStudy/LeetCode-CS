//-----------------------------------------------------------------------------
// Runtime: 340ms
// Memory Usage: 32.5 MB
// Link: https://leetcode.com/submissions/detail/363126904/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0750_NumberOfCornerRectangles
    {
        public int CountCornerRectangles(int[][] grid)
        {
            int n = grid.Length, m = grid[0].Length;
            int result = 0;
            for (int r1 = 0; r1 < n; r1++)
                for (int r2 = r1 + 1; r2 < n; r2++)
                {
                    int find = 0;
                    for (int c = 0; c < m; c++)
                        if (grid[r1][c] == 1 && grid[r2][c] == 1)
                            find++;
                    result += find * (find - 1) / 2;
                }
            return result;
        }
    }
}
