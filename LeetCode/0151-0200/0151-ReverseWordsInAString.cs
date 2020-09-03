//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.9 MB
// Link: https://leetcode.com/submissions/detail/367112653/
//-----------------------------------------------------------------------------

using System;
using System.Linq;

namespace LeetCode
{
    public class _0151_ReverseWordsInAString
    {
        public string ReverseWords(string s) {
            if (string.IsNullOrWhiteSpace(s)) return string.Empty;

            return string.Join(" ", s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Reverse());
        }
    }
}
