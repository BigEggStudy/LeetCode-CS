//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.6 MB
// Link: https://leetcode.com/submissions/detail/343634598/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1228_MissingNumberInArithmeticProgression
    {
        public int MissingNumber(int[] arr)
        {
            var diff = (arr[arr.Length - 1] - arr[0]) / arr.Length;

            int lo = 0;
            int hi = arr.Length - 1;

            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;

                if (arr[mid] == (arr[0] + mid * diff))
                    lo = mid + 1;
                else
                    hi = mid - 1;
            }

            return arr[hi] + diff;
        }
    }
}
