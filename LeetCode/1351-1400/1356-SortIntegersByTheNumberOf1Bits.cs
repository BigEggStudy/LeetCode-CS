//-----------------------------------------------------------------------------
// Runtime: 248ms
// Memory Usage: 32.5 MB
// Link: https://leetcode.com/submissions/detail/329237127/
//-----------------------------------------------------------------------------

using System.Linq;

namespace LeetCode
{
    public class _1356_SortIntegersByTheNumberOf1Bits
    {
        public int[] SortByBits(int[] arr)
        {
            return arr.OrderBy(num =>
            {
                var count = 0;
                while (num > 0)
                {
                    num = num & (num - 1);
                    count++;
                }
                return count;
            }).ThenBy(num => num).ToArray();
        }
    }
}
