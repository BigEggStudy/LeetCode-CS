//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 23.4 MB
// Link: https://leetcode.com/submissions/detail/335026204/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0824_GoatLatin
    {
        public string ToGoatLatin(string S)
        {
            var vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            var wordIndex = 1;
            var sb = new StringBuilder();
            foreach (var word in S.Split())
            {
                if (vowels.Contains(word[0]))
                    sb.Append(word);
                else
                {
                    sb.Append(word.Substring(1));
                    sb.Append(word.Substring(0, 1));
                }

                sb.Append("ma");
                sb.Append(new string('a', wordIndex++));
                sb.Append(" ");
            }

            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
    }
}
