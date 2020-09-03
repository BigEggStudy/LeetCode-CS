//-----------------------------------------------------------------------------
// Runtime: 284ms
// Memory Usage: 33.4 MB
// Link: https://leetcode.com/submissions/detail/369751390/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _1087_BraceExpansion
    {
        public string[] Expand(string S)
        {
            var map = new List<IList<char>>();
            var inBrace = false;

            var chars = new List<char>();
            foreach (var ch in S)
            {
                if (ch == '{')
                    inBrace = true;
                else if (ch == '}')
                {
                    inBrace = false;
                    chars.Sort();
                    map.Add(chars);
                    chars = new List<char>();
                }
                else if (inBrace)
                {
                    if (ch != ',')
                        chars.Add(ch);
                }
                else
                    map.Add(new List<char>() { ch });
            }

            var result = new List<string>();
            DFS(map, 0, new StringBuilder(), result);
            return result.ToArray();
        }

        private void DFS(List<IList<char>> map, int index, StringBuilder sb, List<string> result)
        {
            if (index == map.Count)
            {
                result.Add(sb.ToString());
                return;
            }

            foreach (var ch in map[index])
            {
                sb.Append(ch);
                DFS(map, index + 1, sb, result);
                sb.Remove(sb.Length - 1, 1);
            }
        }
    }
}
