//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 25 MB
// Link: https://leetcode.com/submissions/detail/371632726/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0154_FindMinimumInRotatedSortedArrayII
    {
        public int FindMin(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            if (nums[nums.Length - 1] > nums[0]) return nums[0];

            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] < nums[right]) right = mid;
                else if (nums[mid] > nums[right]) left = mid + 1;
                else right--;
            }

            return nums[right];
        }
    }
}
