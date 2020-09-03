//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25.9 MB
// Link: https://leetcode.com/submissions/detail/330181288/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1064_FixedPoint
    {
        public int FixedPoint(int[] A)
        {
            int lo = 0, hi = A.Length - 1;
            while (lo < hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (A[mid] < mid)
                    lo = mid + 1;
                else
                    hi = mid;
            }

            if (lo < A.Length && A[lo] == lo)
                return lo;
            return -1;
        }
    }
}
