//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 24.9 MB
// Link: https://leetcode.com/submissions/detail/352381504/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _0758_BoldWordsInString
    {
        public string BoldWords(string[] words, string S)
        {
            var bold = new bool[S.Length + 1];
            foreach (var word in words)
            {
                var startIndex = S.IndexOf(word, 0);
                while (startIndex >= 0)
                {
                    for (int i = 0; i < word.Length; i++)
                        bold[i + startIndex] = true;
                    startIndex = S.IndexOf(word, startIndex + 1);
                }
            }

            var sb = new StringBuilder();
            if (bold[0])
                sb.Append("<b>");

            for (int i = 0; i < S.Length; i++)
            {
                sb.Append(S[i]);
                if (!bold[i] && bold[i + 1])
                    sb.Append("<b>");
                if (bold[i] && !bold[i + 1])
                    sb.Append("</b>");
            }

            return sb.ToString();
        }
    }
}
