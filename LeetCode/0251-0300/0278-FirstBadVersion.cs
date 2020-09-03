//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.5 MB
// Link: https://leetcode.com/submissions/detail/333010074/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /* The isBadVersion API is defined in the parent class VersionControl.
          bool IsBadVersion(int version); */

    public class _0278_FirstBadVersion : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                    right = mid;
                else
                    left = mid + 1;
            }
            return left;
        }
    }

    public class VersionControl
    {
        public bool IsBadVersion(int version)
        {
            return version > 3;
        }
    }
}
