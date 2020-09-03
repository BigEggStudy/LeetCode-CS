//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.6 MB
// Link: https://leetcode.com/submissions/detail/330733567/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0509_FibonacciNumber
    {
        public int Fib(int N)
        {
            if (N == 0) return 0;
            if (N == 1) return 1;

            var prev1 = 0;
            var prev2 = 1;
            for (int i = 2; i < N; i++)
            {
                var temp = prev1 + prev2;
                prev1 = prev2;
                prev2 = temp;
            }

            return prev1 + prev2;
        }
    }
}
