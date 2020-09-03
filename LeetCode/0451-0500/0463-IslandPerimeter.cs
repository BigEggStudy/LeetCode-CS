//-----------------------------------------------------------------------------
// Runtime: 176ms
// Memory Usage: 29.2 MB
// Link: https://leetcode.com/submissions/detail/334992582/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0463_IslandPerimeter
    {
        public int IslandPerimeter(int[][] grid)
        {
            var result = 0;

            var row = grid.Length;
            var col = grid[0].Length;
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        result += 4;
                        if (i > 0 && grid[i - 1][j] == 1)
                            result -= 2;
                        if (j > 0 && grid[i][j - 1] == 1)
                            result -= 2;
                    }
                }

            return result;
        }
    }
}
