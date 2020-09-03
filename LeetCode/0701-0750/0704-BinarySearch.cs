//-----------------------------------------------------------------------------
// Runtime: 120ms
// Memory Usage: 35.3 MB
// Link: https://leetcode.com/submissions/detail/344219001/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0704_BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int lo = 0, hi = nums.Length - 1;

            while (lo <= hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] > target) hi = mid - 1;
                else lo = mid + 1;
            }

            return -1;
        }
    }
}
