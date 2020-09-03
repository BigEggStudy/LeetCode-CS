//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 31.4 MB
// Link: https://leetcode.com/submissions/detail/378582740/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _017_LetterCombinationsOfAPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            string[] phoneChars = new string[] { " ",
                                                 "",
                                                 "abc",
                                                 "def",
                                                 "ghi",
                                                 "jkl",
                                                 "mno",
                                                 "pqrs",
                                                 "tuv",
                                                 "wxyz"
                                               };

            if (digits.Length == 0) return new List<string>();

            var results = new List<string>() { "" };
            foreach (var digit in digits)
            {
                var keys = phoneChars[digit - '0'];
                if (keys.Length == 0) continue;

                var temp = new List<string>();
                foreach (var result in results)
                    foreach (var ch in keys)
                        temp.Add(result + ch.ToString());

                results = temp;
            }

            if (results.Count == 1 && results[0] == "") results.Clear();
            return results;
        }
    }
}
