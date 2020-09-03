//-----------------------------------------------------------------------------
// Runtime: 180ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0727_MinimumWindowSubsequence
    {
        public string MinWindow(string S, string T)
        {
            int m = T.Length, n = S.Length;
            var dp = new int[m + 1, n + 1];
            for (int i = 0; i <= n; i++)
                dp[0, i] = i + 1;

            for (int i = 1; i <= m; i++)
                for (int j = 1; j <= n; j++)
                    if (T[i - 1] == S[j - 1])
                        dp[i, j] = dp[i - 1, j - 1];
                    else
                        dp[i, j] = dp[i, j - 1];

            int start = 0, len = n + 1;
            for (int i = 1; i <= n; i++)
                if (dp[m, i] != 0 && i - dp[m, i] + 1 < len)
                {
                    start = dp[m, i] - 1;
                    len = i - dp[m, i] + 1;
                }

            return len == n + 1 ? string.Empty : S.Substring(start, len);
        }
    }
}
