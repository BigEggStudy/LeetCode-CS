//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 32.6 MB
// Link: https://leetcode.com/submissions/detail/351033051/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1470_ShuffleTheArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var results = new int[nums.Length];

            var index = 0;
            for (int i = 0, j = n; i < n; i++, j++)
            {
                results[index++] = nums[i];
                results[index++] = nums[j];
            }

            return results;
        }
    }
}
