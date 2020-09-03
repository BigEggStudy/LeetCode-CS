//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 22.4 MB
// Link: https://leetcode.com/submissions/detail/352847348/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _1119_RemoveVowelsFromAString
    {
        public string RemoveVowels(string S)
        {
            var sb = new StringBuilder();
            foreach (var ch in S)
            {
                switch (ch)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        continue;
                    default:
                        sb.Append(ch);
                        break;
                }
            }

            return sb.ToString();
        }
    }
}
