//-----------------------------------------------------------------------------
// Runtime: 168ms
// Memory Usage: 39.9 MB
// Link: https://leetcode.com/submissions/detail/369270653/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1437_CheckIfAll1SAreAtLeastLengthKPlacesAway
    {
        public bool KLengthApart(int[] nums, int k)
        {
            if (k == 0) return true;

            var lastIndex = -k - 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) continue;
                if (i - lastIndex <= k) return false;

                lastIndex = i;
            }

            return true;
        }
    }
}
