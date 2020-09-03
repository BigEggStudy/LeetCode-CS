//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0153_FindMinimumInRotatedSortedArray
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
                else left = mid + 1;
            }

            return nums[right];
        }
    }
}
