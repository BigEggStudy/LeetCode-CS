//-----------------------------------------------------------------------------
// Runtime: 220ms
// Memory Usage: 31.9 MB
// Link: https://leetcode.com/submissions/detail/336933100/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0293_FlipGame
    {
        public IList<string> GeneratePossibleNextMoves(string s)
        {
            var result = new List<string>();

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1] && s[i] == '+')
                    result.Add(s.Substring(0, i) + "--" + s.Substring(i + 2));
            }

            return result;
        }
    }
}
