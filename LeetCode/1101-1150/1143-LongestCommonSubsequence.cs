//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 25.8 MB
// Link: https://leetcode.com/submissions/detail/330665928/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1143_LongestCommonSubsequence
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            if (text1.Length > text2.Length) return LongestCommonSubsequence(text2, text1);

            var dp = new int[text1.Length + 1];
            for (int j = text2.Length - 1; j >= 0; j--)
            {
                int[] current = new int[text1.Length + 1];
                for (int i = text1.Length - 1; i >= 0; i--)
                {
                    if (text1[i] == text2[j])
                        current[i] = dp[i + 1] + 1;
                    else
                        current[i] = Math.Max(current[i + 1], dp[i]);
                }
                dp = current;
            }

            return dp[0];
        }
    }
}
