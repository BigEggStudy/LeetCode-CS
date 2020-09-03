//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25.1 MB
// Link: https://leetcode.com/submissions/detail/351043908/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1464_MaximumProductOfTwoElementsInAnArray
    {
        public int MaxProduct(int[] nums)
        {
            int m = int.MinValue, n = int.MinValue;
            foreach (var num in nums)
            {
                if (num > n)
                    if (num >= m)
                    {
                        n = m;
                        m = num;
                    }
                    else
                        n = num;
            }

            return (m - 1) * (n - 1);
        }
    }
}
