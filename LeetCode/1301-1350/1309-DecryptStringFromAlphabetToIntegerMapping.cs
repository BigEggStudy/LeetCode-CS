//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 22.6 MB
// Link: https://leetcode.com/submissions/detail/327823201/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _1309_DecryptStringFromAlphabetToIntegerMapping
    {
        public string FreqAlphabets(string s)
        {
            var index = 0;
            var sb = new StringBuilder();

            while (index < s.Length)
            {
                if (index + 2 < s.Length && s[index + 2] == '#')
                {
                    var code = int.Parse(s.Substring(index, 2)) - 1;
                    sb.Append((char)('a' + code));
                    index += 3;
                }
                else
                {
                    var code = int.Parse(s.Substring(index, 1)) - 1;
                    sb.Append((char)('a' + code));
                    index++;
                }
            }

            return sb.ToString();
        }
    }
}
