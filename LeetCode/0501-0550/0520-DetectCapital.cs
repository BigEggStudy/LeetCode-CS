//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 23.3 MB
// Link: https://leetcode.com/submissions/detail/343638258/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0520_DetectCapital
    {
        public bool DetectCapitalUse(string word)
        {
            var upper = 0;
            foreach (var ch in word)
                if (ch >= 'A' && ch <= 'Z')
                    upper++;

            if (upper == 1 && word[0] <= 'Z') return true;
            return upper == 0 || upper == word.Length;
        }
    }
}
