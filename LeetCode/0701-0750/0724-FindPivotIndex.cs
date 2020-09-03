//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 31 MB
// Link: https://leetcode.com/submissions/detail/352788251/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0724_FindPivotIndex
    {
        public int PivotIndex(int[] nums)
        {
            var sum = 0;
            foreach (var num in nums)
                sum += num;

            var leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == sum - leftSum - nums[i]) return i;
                leftSum += nums[i];
            }

            return -1;
        }
    }
}
