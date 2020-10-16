//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25.5 MB
// Link: https://leetcode.com/submissions/detail/409549251/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _074_SearchA2DMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix.Length == 0) return false;

            int columnLength = matrix[0].Length;
            int lo = 0, hi = matrix.Length * columnLength - 1;
            int i, j;
            while (lo <= hi)
            {
                var mid = lo + (hi - lo) / 2;
                i = mid / columnLength;
                j = mid % columnLength;
                if (matrix[i][j] < target) { lo = mid + 1; }
                else if (matrix[i][j] > target) { hi = mid - 1; }
                else { return true; }
            }
            return false;
        }
    }
}
