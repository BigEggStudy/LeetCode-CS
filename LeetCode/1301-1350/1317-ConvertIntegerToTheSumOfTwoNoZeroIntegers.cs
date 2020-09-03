//-----------------------------------------------------------------------------
// Runtime: 196ms
// Memory Usage: 25.5 MB
// Link: https://leetcode.com/submissions/detail/339139993/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1317_ConvertIntegerToTheSumOfTwoNoZeroIntegers
    {
        public int[] GetNoZeroIntegers(int n)
        {
            int p1 = 1, p2 = n - 1;

            while (p1.ToString().Contains("0") || p2.ToString().Contains("0"))
            {
                p1++;
                p2--;
            }

            return new int[] { p1, p2 };
        }
    }
}
