//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 22.5 MB
// Link: https://leetcode.com/submissions/detail/364001262/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _0791_CustomSortString
    {
        public string CustomSortString(string S, string T)
        {
            var counts = new int[26];
            foreach (var ch in T)
                counts[ch - 'a']++;

            var sb = new StringBuilder();
            foreach (var ch in S)
            {
                sb.Append(ch, counts[ch - 'a']);
                counts[ch - 'a'] = 0;
            }

            for (char ch = 'a'; ch <= 'z'; ch++)
                sb.Append(ch, counts[ch - 'a']);

            return sb.ToString();
        }
    }
}
