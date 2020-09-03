//-----------------------------------------------------------------------------
// Runtime: 156ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _081_SearchInRotatedSortedArray2
    {
        public bool Search(int[] nums, int target)
        {
            int lo = 0, hi = nums.Length - 1;
            int mid, loValue, hiValue, midValue;

            while (lo <= hi)
            {
                loValue = nums[lo];
                hiValue = nums[hi];
                if (loValue < hiValue && (target < loValue || target > hiValue))
                {
                    return false;
                }

                while (lo < hi && nums[lo] == hiValue)
                {
                    lo++;
                }
                loValue = nums[lo];

                mid = lo + (hi - lo) / 2;
                midValue = nums[mid];
                if (target == midValue) { return true; }

                if (loValue <= midValue)
                {
                    if (loValue <= target && target < midValue)
                    {
                        hi = mid - 1;
                    }
                    else
                    {
                        lo = mid + 1;
                    }
                }
                else
                {
                    if (target <= hiValue && midValue < target)
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        hi = mid - 1;
                    }
                }
            }

            return false;
        }
    }
}
