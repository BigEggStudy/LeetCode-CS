//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 24.1 MB
// Link: https://leetcode.com/submissions/detail/327836848/
//-----------------------------------------------------------------------------

using System.Linq;

namespace LeetCode
{
    public class _1085_SumOfDigitsInTheMinimumNumber
    {
        public int SumOfDigits(int[] A)
        {
            var min = A.Min();
            var sum = 0;
            while (min > 0)
            {
                sum += min % 10;
                min /= 10;
            }

            return sum % 2 == 0 ? 1 : 0;
        }
    }
}
