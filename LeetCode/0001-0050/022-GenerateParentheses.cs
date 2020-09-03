//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 32.7 MB
// Link: https://leetcode.com/submissions/detail/378567461/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _022_GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var results = new List<string>();
            if (n > 0) { GenerateParenthesis(n, n, results, ""); }
            return results;
        }

        void GenerateParenthesis(int l, int r, IList<string> results, string s)
        {
            if (l == 0)
            {
                s += new string(')', r);
                results.Add(s);
                return;
            }

            GenerateParenthesis(l - 1, r, results, s + "(");
            if (r > l)
            {
                GenerateParenthesis(l, r - 1, results, s + ")");
            }
        }
    }
}
