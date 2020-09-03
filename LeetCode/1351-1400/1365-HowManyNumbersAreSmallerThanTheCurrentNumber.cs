//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 31.8 MB
// Link: https://leetcode.com/submissions/detail/326434905/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1365_HowManyNumbersAreSmallerThanTheCurrentNumber
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var rank = new int[101];
            foreach (var num in nums)
                rank[num]++;

            var count = 0;
            for (int i = 0; i < 101; i++)
            {
                var temp = rank[i];
                rank[i] = count;
                count += temp;
            }

            var results = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
                results[i] = rank[nums[i]];

            return results;
        }
    }
}
