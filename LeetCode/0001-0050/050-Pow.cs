//-----------------------------------------------------------------------------
// Runtime: 48ms
// Memory Usage: 15 MB
// Link: https://leetcode.com/submissions/detail/367515347/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _050_Pow
    {
        public double MyPow(double x, int n)
        {
            if (x == 0 || x == 1) return x;
            if (n == 0) return 1;

            var temp = MyPow(x, n / 2);

            if (n % 2 == 0) return temp * temp;
            return n > 0 ? x * temp * temp : (temp * temp) / x;
        }
    }
}
