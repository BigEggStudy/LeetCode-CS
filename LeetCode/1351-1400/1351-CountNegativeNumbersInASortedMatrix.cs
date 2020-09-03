//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 28.8 MB
// Link: https://leetcode.com/submissions/detail/327409720/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1351_CountNegativeNumbersInASortedMatrix
    {
        public int CountNegatives(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length - 1;

            var count = 0;
            for (int i = 0; i < n; i++)
            {
                if (grid[i][m] < 0)
                {
                    count += n - i;
                    m--;
                    i--;
                    if (m < 0) break;
                }
            }

            return count;
        }
    }
}
