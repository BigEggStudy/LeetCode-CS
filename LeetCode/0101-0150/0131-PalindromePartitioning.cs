//-----------------------------------------------------------------------------
// Runtime: 260ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0131_PalindromePartitioning
    {
        public IList<IList<string>> Partition(string s)
        {
            var dp = new bool[s.Length, s.Length];
            for (int i = 0; i < s.Length; i++)
                for (int j = 0; j <= i; j++)
                    if (s[i] == s[j] && (i - j <= 2 || dp[j + 1, i - 1]))
                        dp[j, i] = true;

            var results = new List<IList<string>>();
            GenerateResult(new List<string>(), results, dp, 0, s);
            return results;
        }

        private void GenerateResult(List<string> current_result, List<IList<string>> results, bool[,] dp, int position, string s)
        {
            if (position == s.Length)
            {
                results.Add(new List<string>(current_result));
                return;
            }

            for (int i = position; i < s.Length; i++)
            {
                if (dp[position, i])
                {
                    current_result.Add(s.Substring(position, i - position + 1));
                    GenerateResult(current_result, results, dp, i + 1, s);
                    current_result.RemoveAt(current_result.Count - 1);
                }
            }
        }
    }
}
