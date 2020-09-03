//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.5 MB
// Link: https://leetcode.com/submissions/detail/361207056/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0861_ScoreAfterFlippingMatrix
    {
        public int MatrixScore(int[][] A)
        {
            var rows = A.Length;
            var cols = A[0].Length;

            var result = 0;
            for (int c = 0; c < cols; c++)
            {
                var colsum = 0;
                for (int r = 0; r < rows; r++)
                    colsum += A[r][c] ^ A[r][0];

                result += Math.Max(colsum, rows - colsum) * (int)Math.Pow(2, cols - c - 1);
            }

            return result;
        }
    }
}
