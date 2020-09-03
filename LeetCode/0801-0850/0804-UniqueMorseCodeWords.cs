//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.8 MB
// Link: https://leetcode.com/submissions/detail/327567110/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0804_UniqueMorseCodeWords
    {
        private readonly string[] MORSE_CODE = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

        public int UniqueMorseRepresentations(string[] words)
        {
            var map = new HashSet<string>();
            foreach (var word in words)
            {
                var sb = new StringBuilder();
                foreach (var ch in word)
                    sb.Append(MORSE_CODE[ch - 'a']);

                map.Add(sb.ToString());
            }

            return map.Count;
        }
    }
}
