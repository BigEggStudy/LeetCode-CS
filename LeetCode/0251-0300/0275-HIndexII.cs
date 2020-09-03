//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 29.4 MB
// Link: https://leetcode.com/submissions/detail/355658427/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0275_HIndexII
    {
        public int HIndex(int[] citations)
        {
            int n = citations.Length;
            int left = 0, right = n - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (citations[mid] == n - mid) return n - mid;
                else if (citations[mid] < n - mid) left = mid + 1;
                else right = mid - 1;
            }

            return n - left;
        }
    }
}
