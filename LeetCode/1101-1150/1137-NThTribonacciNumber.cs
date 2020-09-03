//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 14.5 MB
// Link: https://leetcode.com/submissions/detail/339606744/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1137_NThTribonacciNumber
    {
        private int[] memo = new int[38];

        public _1137_NThTribonacciNumber()
        {
            memo[0] = 0;
            memo[1] = 1;
            memo[2] = 1;
        }

        public int Tribonacci(int n)
        {
            if (n < 3) return memo[n];
            if (memo[n] != 0) return memo[n];

            for (int i = 3; i <= n; i++)
            {
                if (memo[i] != 0) continue;
                memo[i] = memo[i - 1] + memo[i - 2] + memo[i - 3];
            }

            return memo[n];
        }
    }
}
