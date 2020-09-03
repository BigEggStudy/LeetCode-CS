//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0162_FindPeakElement
    {
        public int FindPeakElement(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] > nums[mid + 1]) right = mid;
                else left = mid + 1;
            }
            return left;
        }
    }
}
