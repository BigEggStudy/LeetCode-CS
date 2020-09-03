//-----------------------------------------------------------------------------
// Runtime: 128ms
// Memory Usage: 34.6 MB
// Link: https://leetcode.com/submissions/detail/344799358/
//-----------------------------------------------------------------------------

using System.Linq;

namespace LeetCode
{
    public class _0453_MinimumMovesToEqualArrayElements
    {
        public int MinMoves(int[] nums)
        {
            var min = nums.Min();
            var count = 0;
            foreach (var num in nums)
                count += num - min;

            return count;
        }
    }
}
