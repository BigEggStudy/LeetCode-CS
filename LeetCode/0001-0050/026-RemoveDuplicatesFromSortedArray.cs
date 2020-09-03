//-----------------------------------------------------------------------------
// Runtime: 248ms
// Memory Usage: 33.4 MB
// Link: https://leetcode.com/submissions/detail/352419066/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _026_RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1) { return nums.Length; }

            var index = 0;
            var lastValue = nums[index];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == lastValue) { continue; }

                nums[++index] = nums[i];
                lastValue = nums[index];
            }

            return index + 1;
        }
    }
}
