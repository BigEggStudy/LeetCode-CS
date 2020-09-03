//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25.7 MB
// Link: https://leetcode.com/submissions/detail/338593825/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0540_SingleElementInASortedArray
    {
        public int SingleNonDuplicate(int[] nums)
        {
            int lo = 0, hi = nums.Length - 1;
            while (lo < hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (mid % 2 == 1) mid--;
                if (nums[mid] == nums[mid + 1])
                    lo = mid + 2;
                else
                    hi = mid;
            }

            return nums[lo];
        }
    }
}
