//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.7 MB
// Link: https://leetcode.com/submissions/detail/351806714/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _035_SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int lo = 0, hi = nums.Length;

            while (lo < hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] < target) lo = mid + 1;
                else hi = mid;
            }

            return lo;
        }
    }
}
