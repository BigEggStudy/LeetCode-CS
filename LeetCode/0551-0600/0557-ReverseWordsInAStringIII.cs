//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 34.8 MB
// Link: https://leetcode.com/submissions/detail/330119313/
//-----------------------------------------------------------------------------

using System.Linq;

namespace LeetCode
{
    public class _0557_ReverseWordsInAStringIII
    {
        public string ReverseWords(string s)
        {
            return string.Join(" ", s.Split(' ').Select(w => new string(w.ToCharArray().Reverse().ToArray())));
        }
    }
}
