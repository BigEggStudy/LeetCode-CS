//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.9 MB
// Link: https://leetcode.com/submissions/detail/327819541/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _1370_IncreasingDecreasingString
    {
        public string SortString(string s)
        {
            var counts = new int[26];
            foreach (var ch in s)
                counts[ch - 'a']++;

            var sb = new StringBuilder();
            while (sb.Length < s.Length)
            {
                for (int i = 0; i < 26; i++)
                    if (counts[i] > 0)
                    {
                        counts[i]--;
                        sb.Append((char)('a' + i));
                    }

                for (int i = 25; i >= 0; i--)
                    if (counts[i] > 0)
                    {
                        counts[i]--;
                        sb.Append((char)('a' + i));
                    }
            }

            return sb.ToString();
        }
    }
}
