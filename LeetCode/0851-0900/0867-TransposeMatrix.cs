//-----------------------------------------------------------------------------
// Runtime: 252ms
// Memory Usage: 35 MB
// Link: https://leetcode.com/submissions/detail/335003524/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0867_TransposeMatrix
    {
        public int[][] Transpose(int[][] A)
        {
            var row = A.Length;
            var col = A[0].Length;

            var result = new int[col][];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    if (i == 0)
                        result[j] = new int[row];
                    result[j][i] = A[i][j];
                }

            return result;
        }
    }
}
