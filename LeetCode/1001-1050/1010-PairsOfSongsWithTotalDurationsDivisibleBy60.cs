//-----------------------------------------------------------------------------
// Runtime: 124ms
// Memory Usage: 32.4 MB
// Link: https://leetcode.com/submissions/detail/351911243/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1010_PairsOfSongsWithTotalDurationsDivisibleBy60
    {
        public int NumPairsDivisibleBy60(int[] time)
        {
            var counts = new int[60];
            var result = 0;
            foreach (var num in time)
            {
                result += counts[(600 - num) % 60];
                counts[num % 60]++;
            }

            return result;
        }
    }
}
