//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 31.7 MB
// Link: https://leetcode.com/submissions/detail/327834999/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0832_FlippingAnImage
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            var row = A.Length;
            var col = A[0].Length;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col / 2; j++)
                {
                    var left = A[i][j];
                    var right = A[i][col - j - 1];

                    A[i][j] = right == 1 ? 0 : 1;
                    A[i][col - j - 1] = left == 1 ? 0 : 1;
                }

                if (col % 2 == 1)
                    A[i][col / 2] = A[i][col / 2] == 1 ? 0 : 1;
            }

            return A;
        }
    }
}
