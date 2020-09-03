//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 26.4 MB
// Link: https://leetcode.com/submissions/detail/328745397/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0852_PeakIndexInAMountainArray
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            int lo = 0, hi = A.Length - 1;
            while (lo < hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (A[mid] < A[mid + 1])
                    lo = mid + 1;
                else
                    hi = mid;
            }

            return lo;
        }
    }
}
