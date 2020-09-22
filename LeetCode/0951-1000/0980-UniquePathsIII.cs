//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 23.5 MB
// Link: https://leetcode.com/submissions/detail/399389571/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0980_UniquePathsIII
    {
        private readonly (int dr, int dc)[] direction = new (int dr, int dc)[4] { (1, 0), (-1, 0), (0, 1), (0, -1) };
        private int count = 0;

        public int UniquePathsIII(int[][] grid)
        {
            int rows = grid.Length, cols = grid[0].Length;
            int nonObstacles = 0, startRow = -1, startCol = -1;

            for (int row = 0; row < rows; row++)
                for (int col = 0; col < cols; col++)
                {
                    int cell = grid[row][col];
                    if (cell >= 0)
                        nonObstacles += 1;
                    if (cell == 1)
                    {
                        startRow = row;
                        startCol = col;
                    }
                }

            Backtrack(grid, startRow, startCol, nonObstacles);
            return this.count;
        }

        private void Backtrack(int[][] grid, int row, int col, int nonObstacles)
        {
            if (grid[row][col] == 2 && nonObstacles == 1)
            {
                this.count++;
                return;
            }

            int rows = grid.Length, cols = grid[0].Length;
            int temp = grid[row][col];
            grid[row][col] = -2;
            nonObstacles -= 1;

            foreach ((int dr, int dc) in direction)
            {
                int newRow = row + dr;
                int newCol = col + dc;

                if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols && grid[newRow][newCol] >= 0)
                    Backtrack(grid, newRow, newCol, nonObstacles);
            }

            grid[row][col] = temp;
        }
    }
}
