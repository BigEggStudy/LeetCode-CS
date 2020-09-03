//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0552_StudentAttendanceRecordII
    {
        private readonly int MOD_NUMBER = 1000000007;

        public int CheckRecord(int n)
        {
            var dp = new long[n < 5 ? 6 : n + 1];
            dp[0] = 1;
            dp[1] = 2;
            dp[2] = 4;
            dp[3] = 7;
            for (int i = 4; i <= n; i++)
                dp[i] = ((2 * dp[i - 1]) % MOD_NUMBER + (MOD_NUMBER - dp[i - 4])) % MOD_NUMBER;

            var sum = dp[n];
            for (int i = 1; i <= n; i++)
                sum += (dp[i - 1] * dp[n - i]) % MOD_NUMBER;

            return (int)(sum % MOD_NUMBER);
        }
    }
}
