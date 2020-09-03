//-----------------------------------------------------------------------------
// Runtime: 256ms
// Memory Usage: 33.3 MB
// Link: https://leetcode.com/submissions/detail/373697376/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0140_WordBreakII
    {
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            var set = new HashSet<string>(wordDict);
            var cache = new Dictionary<string, IList<string>>();

            return DFS(s, set, cache);
        }

        public IList<string> DFS(string s, HashSet<string> set, Dictionary<string, IList<string>> cache)
        {
            if (cache.ContainsKey(s)) return cache[s];

            var result = new List<string>();
            if (set.Contains(s))
            {
                result.Add(s);
            }

            for (int i = 1; i < s.Length; i++)
            {
                var str = s.Substring(i);
                if (set.Contains(str))
                {
                    var prevResults = DFS(s.Substring(0, i), set, cache);
                    foreach (var prev in prevResults)
                        result.Add(prev + " " + str);
                }
            }

            cache[s] = result;
            return result;
        }
    }
}
