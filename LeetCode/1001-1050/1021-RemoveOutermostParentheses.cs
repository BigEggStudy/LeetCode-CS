//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 23.4 MB
// Link: https://leetcode.com/submissions/detail/327414524/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _1021_RemoveOutermostParentheses
    {
        public string RemoveOuterParentheses(string S)
        {
            if (S.Length <= 2) return string.Empty;

            var sb = new StringBuilder();
            var count = 0;
            var start = 0;

            for (int i = 0; i < S.Length; i++)
            {
                count += S[i] == '(' ? 1 : -1;
                if (count == 0)
                {
                    if (i - start - 1 > 0)
                        sb.Append(S.Substring(start + 1, i - start - 1));
                    start = i + 1;
                }
            }

            return sb.ToString();
        }
    }
}
