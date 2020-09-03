//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.4 MB
// Link: https://leetcode.com/submissions/detail/336978508/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1150_CheckIfANumberIsMajorityElementInASortedArray
    {
        public bool IsMajorityElement(int[] nums, int target)
        {
            var count = 0;
            foreach (var num in nums)
                if (num == target) count++;

            return count > nums.Length / 2;
        }
    }
}
