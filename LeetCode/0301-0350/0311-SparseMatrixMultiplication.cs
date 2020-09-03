//-----------------------------------------------------------------------------
// Runtime: 260ms
// Memory Usage: 31.7 MB
// Link: https://leetcode.com/submissions/detail/370216688/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0311_SparseMatrixMultiplication
    {
        public int[][] Multiply(int[][] A, int[][] B)
        {
            int N = A.Length;
            int M = A[0].Length;
            int P = B[0].Length;

            var result = new int[N][];

            for (int i = 0; i < N; i++)
            {
                result[i] = new int[P];

                for (int j = 0; j < P; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < M; k++)
                        sum += A[i][k] * B[k][j];
                    result[i][j] = sum;
                }
            }

            return result;
        }
    }
}
