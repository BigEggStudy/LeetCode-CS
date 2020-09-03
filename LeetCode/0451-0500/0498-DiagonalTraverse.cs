//-----------------------------------------------------------------------------
// Runtime: 288ms
// Memory Usage: 37 MB
// Link: https://leetcode.com/submissions/detail/375104923/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0498_DiagonalTraverse
    {
        public int[] FindDiagonalOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0) return new int[0];

            int N = matrix.Length;
            int M = matrix[0].Length;

            int[] result = new int[N * M];
            int row = 0, col = 0;
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = matrix[row][col];
                if ((row + col) % 2 == 0)
                {
                    if (col == M - 1) { row++; }
                    else if (row == 0) { col++; }
                    else { row--; col++; }
                }
                else
                {
                    if (row == N - 1) { col++; }
                    else if (col == 0) { row++; }
                    else { row++; col--; }
                }
            }

            return result;
        }
    }
}
