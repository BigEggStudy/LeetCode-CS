//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 23.9 MB
// Link: https://leetcode.com/submissions/detail/368367163/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1512_NumberOfGoodPairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var counts = new int[101];
            foreach (var num in nums)
                counts[num]++;

            var result = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (counts[i] >= 2)
                    result += counts[i] * (counts[i] - 1) / 2;
            }

            return result;
        }
    }
}
