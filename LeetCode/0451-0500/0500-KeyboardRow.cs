//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 30.1 MB
// Link: https://leetcode.com/submissions/detail/334979343/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0500_KeyboardRow
    {
        public string[] FindWords(string[] words)
        {
            if (words.Length == 0) return words;

            var map = new Dictionary<char, int>();
            string r1 = "qwertyuiopQWERTYUIOP";
            foreach (var ch in r1)
                map[ch] = 1;
            string r2 = "asdfghjklASDFGHJKL";
            foreach (var ch in r2)
                map[ch] = 2;
            string r3 = "zxcvbnmZXCVBNM";
            foreach (var ch in r3)
                map[ch] = 3;

            var result = new List<string>();
            foreach (var word in words)
            {
                var flag = map[word[0]];
                var valid = true;
                foreach (var ch in word)
                {
                    if (flag != map[ch])
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                    result.Add(word);
            }

            return result.ToArray();
        }
    }
}
