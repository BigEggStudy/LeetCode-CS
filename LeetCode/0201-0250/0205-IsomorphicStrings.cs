//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 21.6 MB
// Link: https://leetcode.com/submissions/detail/260098104/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0205_IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var map = new Dictionary<char, char>(26);
            var visited = new HashSet<char>(26);
            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    if (map[s[i]] != t[i]) return false;
                }
                else
                {
                    if (visited.Contains(t[i])) return false;
                    map.Add(s[i], t[i]);
                    visited.Add(t[i]);
                }
            }
            return true;
        }
    }
}
