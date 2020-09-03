//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _115_DistinctSubsequences
    {
        public int NumDistinct(string s, string t)
        {
            if (string.IsNullOrEmpty(t)) return 1;
            if (string.IsNullOrEmpty(s)) return 0;

            var dp = new int[t.Length + 1, s.Length + 1];
            for (int i = 0; i <= s.Length; i++)
                dp[0, i] = 1;
            for (int i = 0; i < t.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (t[i] == s[j]) dp[i + 1, j + 1] = dp[i + 1, j] + dp[i, j];
                    else dp[i + 1, j + 1] = dp[i + 1, j];
                }
                //  Fast Prune
                if (dp[i + 1, s.Length - (t.Length - i) + 1] == 0) return 0;
            }

            return dp[t.Length, s.Length];
        }
    }
}
