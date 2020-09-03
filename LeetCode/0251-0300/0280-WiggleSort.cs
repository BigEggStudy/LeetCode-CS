//-----------------------------------------------------------------------------
// Runtime: 260ms
// Memory Usage: 33.4 MB
// Link: https://leetcode.com/submissions/detail/369274380/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0280_WiggleSort
    {
        public void WiggleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (!(i % 2 == 0 ^ nums[i] > nums[i + 1]))
                {
                    var temp = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = temp;
                }
            }
        }
    }
}
