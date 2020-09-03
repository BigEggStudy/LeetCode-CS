//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 32 MB
// Link: https://leetcode.com/submissions/detail/379089611/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _034_SearchForARange
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int lo = 0, hi = nums.Length - 1, mid;
            while (lo <= hi)
            {
                mid = lo + (hi - lo) / 2;
                if (target > nums[mid])
                    lo = mid + 1;
                else
                    hi = mid - 1;
            }
            if (lo == nums.Length || nums[lo] != target)
                return new int[] { -1, -1 };

            var result = new int[2];
            result[0] = lo;

            lo = 0; hi = nums.Length - 1;
            while (lo <= hi)
            {
                mid = lo + (hi - lo) / 2;
                if (target >= nums[mid])
                    lo = mid + 1;
                else
                    hi = mid - 1;
            }
            result[1] = lo - 1;

            return result;
        }
    }
}
