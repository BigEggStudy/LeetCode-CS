//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 27.4 MB
// Link: https://leetcode.com/submissions/detail/352384140/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _0616_AddBoldTagInString
    {
        public string AddBoldTag(string s, string[] dict)
        {
            var bold = new bool[s.Length + 1];
            foreach (var word in dict)
            {
                var startIndex = s.IndexOf(word, 0);
                while (startIndex >= 0)
                {
                    for (int i = 0; i < word.Length; i++)
                        bold[i + startIndex] = true;
                    startIndex = s.IndexOf(word, startIndex + 1);
                }
            }

            var sb = new StringBuilder();
            if (bold[0])
                sb.Append("<b>");

            for (int i = 0; i < s.Length; i++)
            {
                sb.Append(s[i]);
                if (!bold[i] && bold[i + 1])
                    sb.Append("<b>");
                if (bold[i] && !bold[i + 1])
                    sb.Append("</b>");
            }

            return sb.ToString();
        }
    }
}
