//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.6 MB
// Link: https://leetcode.com/submissions/detail/352845530/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0747_LargestNumberAtLeastTwiceOfOthers
    {
        public int DominantIndex(int[] nums)
        {
            int max1 = int.MinValue, max2 = int.MinValue;
            int index = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (num > max2)
                    if (num >= max1)
                    {
                        max2 = max1;
                        max1 = num;
                        index = i;
                    }
                    else
                    {
                        max2 = num;
                    }
            }

            return max1 >= 2 * max2 ? index : -1;
        }
    }
}
