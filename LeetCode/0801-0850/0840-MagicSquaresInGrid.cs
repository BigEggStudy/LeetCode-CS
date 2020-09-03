//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.2 MB
// Link: https://leetcode.com/submissions/detail/358734910/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0840_MagicSquaresInGrid
    {
        public int NumMagicSquaresInside(int[][] grid)
        {
            int rows = grid.Length, cols = grid[0].Length;
            int ans = 0;
            for (int r = 1; r < rows - 1; r++)
                for (int c = 1; c < cols - 1; c++)
                {
                    if (grid[r][c] != 5) continue;
                    if (IsMagic(new int[] { grid[r - 1][c - 1], grid[r - 1][c],     grid[r - 1][c + 1],
                                            grid[r][c - 1],     grid[r][c],         grid[r][c + 1],
                                            grid[r + 1][c - 1], grid[r + 1][c],     grid[r + 1][c + 1] }))
                        ans++;
                }

            return ans;
        }

        private bool IsMagic(int[] arr)
        {
            var count = new int[16];
            foreach (int val in arr)
                count[val]++;

            for (int i = 1; i <= 9; i++)
                if (count[i] != 1)
                    return false;

            return (arr[0] + arr[1] + arr[2] == 15 &&
                    arr[3] + arr[4] + arr[5] == 15 &&
                    arr[6] + arr[7] + arr[8] == 15 &&
                    arr[0] + arr[3] + arr[6] == 15 &&
                    arr[1] + arr[4] + arr[7] == 15 &&
                    arr[2] + arr[5] + arr[8] == 15 &&
                    arr[0] + arr[4] + arr[8] == 15 &&
                    arr[2] + arr[4] + arr[6] == 15);
        }
    }
}
