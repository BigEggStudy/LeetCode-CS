//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 33 MB
// Link: https://leetcode.com/submissions/detail/352825140/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0459_RepeatedSubstringPattern
    {
        public bool RepeatedSubstringPattern(string s)
        {
            var N = s.Length;
            var dp = new int[N];

            for (int i = 1; i < N; i++)
            {
                int j = dp[i - 1];
                while (j > 0 && s[j] != s[i])
                    j = dp[j - 1];
                if (s[i] == s[j])
                    j++;
                dp[i] = j;
            }

            return dp[N - 1] > 0 && N % (N - dp[N - 1]) == 0;
        }
    }
}
