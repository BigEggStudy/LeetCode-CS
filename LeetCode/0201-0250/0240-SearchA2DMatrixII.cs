//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0240_SearchA2DMatrixII
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            var n = matrix.GetLength(0);
            var i = 0;
            var m = matrix.GetLength(1) - 1;

            while (i < n && m >= 0)
            {
                var cmp = matrix[i, m].CompareTo(target);
                if (cmp == 0) return true;
                else if (cmp > 0) m--;
                else i++;
            }
            return false;
        }
    }
}
