//-----------------------------------------------------------------------------
// Runtime: 160ms
// Memory Usage: 39.8 MB
// Link: https://leetcode.com/submissions/detail/338646772/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0896_MonotonicArray
    {
        public bool IsMonotonic(int[] A)
        {
            if (A.Length <= 2) return true;

            var i = 0;
            while (i < A.Length - 1 && A[i] == A[i + 1])
                i++;

            if (i == A.Length - 1) return true;

            var isIncreasing = A[i] < A[i + 1];
            i++;
            if (isIncreasing)
            {
                for (int k = i; k < A.Length - 1; k++)
                    if (A[k] > A[k + 1]) return false;
            }
            else
            {
                for (int k = i; k < A.Length - 1; k++)
                    if (A[k] < A[k + 1]) return false;
            }
            return true;
        }
    }
}
