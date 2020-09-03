//-----------------------------------------------------------------------------
// Runtime: 164ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _074_SearchA2DMatrix
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int columnLength = matrix.GetLength(1);
            int lo = 0, hi = matrix.Length - 1, mid = 0;
            int i, j;
            while (lo <= hi)
            {
                mid = lo + (hi - lo) / 2;
                i = mid / columnLength;
                j = mid % columnLength;
                if (matrix[i, j] < target) { lo = mid + 1; }
                else if (matrix[i, j] > target) { hi = mid - 1; }
                else { return true; }
            }
            return false;
        }
    }
}
