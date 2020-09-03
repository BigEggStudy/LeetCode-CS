//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25.8 MB
// Link: https://leetcode.com/submissions/detail/326443837/
//-----------------------------------------------------------------------------

using System.Linq;

namespace LeetCode
{
    public class _1295_FindNumbersWithEvenNumberOfDigits
    {
        public int FindNumbers(int[] nums)
        {
            return nums.Count(num => num.ToString().Length % 2 == 0);
        }
    }
}
