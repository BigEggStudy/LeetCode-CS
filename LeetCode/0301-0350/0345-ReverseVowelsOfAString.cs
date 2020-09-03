//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 27 MB
// Link: https://leetcode.com/submissions/detail/352774402/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0345_ReverseVowelsOfAString
    {
        public string ReverseVowels(string s)
        {
            var vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int i = 0, j = s.Length - 1;

            var sb = new StringBuilder(s);
            while (i < j)
            {
                while (i < s.Length && !vowels.Contains(sb[i]))
                    i++;
                while (j >= 0 && !vowels.Contains(sb[j]))
                    j--;

                if (i == s.Length) break;
                if (j == -1) break;

                if (i >= j) break;

                var temp = sb[i];
                sb[i] = sb[j];
                sb[j] = temp;

                i++;
                j--;
            }

            return sb.ToString();
        }
    }
}
