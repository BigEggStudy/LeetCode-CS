//-----------------------------------------------------------------------------
// Runtime: 260ms
// Memory Usage: 33.7 MB
// Link: https://leetcode.com/submissions/detail/336961634/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0566_ReshapeTheMatrix
    {
        public int[][] MatrixReshape(int[][] nums, int r, int c)
        {
            var rows = nums.Length;
            var cols = nums[0].Length;

            if (rows * cols != r * c) return nums;

            int[][] result = new int[r][];
            int row = 0, col = 0;
            result[row] = new int[c];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[row][col++] = nums[i][j];
                    if (col == c)
                    {
                        row++;
                        if (row < r)
                            result[row] = new int[c];
                        col = 0;
                    }
                }
            }
            return result;
        }
    }
}
