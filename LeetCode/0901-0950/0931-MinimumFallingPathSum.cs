//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 26.5 MB
// Link: https://leetcode.com/submissions/detail/370207934/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0931_MinimumFallingPathSum
    {
        public int MinFallingPathSum(int[][] A)
        {
            int N = A.Length;
            if (N == 1) return A[0][0];

            var path = new int[N, N];
            for (int i = 0; i < N; i++)
                path[0, i] = A[0][i];

            var min = int.MaxValue;
            for (int row = 1; row < N; row++)
                for (int col = 0; col < N; col++)
                {
                    var above = path[row - 1, col];
                    if (col > 0)
                        above = Math.Min(above, path[row - 1, col - 1]);
                    if (col < N - 1)
                        above = Math.Min(above, path[row - 1, col + 1]);

                    path[row, col] = above + A[row][col];

                    if (row == N - 1)
                    {
                        min = Math.Min(min, path[row, col]);
                    }
                }

            return min;
        }
    }
}
