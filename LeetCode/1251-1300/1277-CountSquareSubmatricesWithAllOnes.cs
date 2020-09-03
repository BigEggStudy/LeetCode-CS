//-----------------------------------------------------------------------------
// Runtime: 164ms
// Memory Usage: 34.1 MB
// Link: https://leetcode.com/submissions/detail/342806396/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1277_CountSquareSubmatricesWithAllOnes
    {
        public int CountSquares(int[][] matrix)
        {
            var rows = matrix.Length;
            var cols = matrix[0].Length;

            var mat = new int[rows + 1, cols + 1];
            var sum = 0;
            for (int i = 1; i <= rows; i++)
                for (int j = 1; j <= cols; j++)
                {
                    if (matrix[i - 1][j - 1] == 1)
                    {
                        mat[i, j] = Math.Min(Math.Min(mat[i - 1, j], mat[i, j - 1]), mat[i - 1, j - 1]) + 1;
                        sum += mat[i, j];
                    }
                }

            return sum;
        }
    }
}
