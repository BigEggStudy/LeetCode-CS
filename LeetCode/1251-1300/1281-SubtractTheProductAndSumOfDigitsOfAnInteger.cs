//-----------------------------------------------------------------------------
// Runtime: 32ms
// Memory Usage: 14.6 MB
// Link: https://leetcode.com/submissions/detail/326436920/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1281_SubtractTheProductAndSumOfDigitsOfAnInteger
    {
        public int SubtractProductAndSum(int n)
        {
            var sum = 0;
            var product = 1;

            while (n > 0)
            {
                var value = n % 10;
                sum += value;
                product *= value;
                n /= 10;
            }

            return product - sum;
        }
    }
}
