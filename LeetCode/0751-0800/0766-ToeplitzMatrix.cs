//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 27.6 MB
// Link: https://leetcode.com/submissions/detail/334982795/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0766_ToeplitzMatrix
    {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            var row = matrix.Length;
            var col = matrix[0].Length;

            for (int i = 1; i < row; i++)
                for (int j = 1; j < col; j++)
                {
                    if (i > 0 && j > 0 && matrix[i - 1][j - 1] != matrix[i][j])
                        return false;
                }

            return true;
        }
    }
}
