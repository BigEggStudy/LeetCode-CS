//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Linq;

namespace LeetCode
{
    public class _087_ScrambleString
    {
        public bool IsScramble(string s1, string s2)
        {
            if (s1 == s2) { return true; }

            var list = Enumerable.Repeat(0, 256).ToArray(); ;
            var len = s1.Length;
            for (var i = 0; i < len; i++)
            {
                list[s1[i]]++;
                list[s2[i]]--;
            }
            if (list.Any(i => i > 0)) { return false; }
            if (len <= 3) { return true; }  // fast pruning.

            for (var i = 1; i < len; i++)
            {
                if ((IsScramble(s1.Substring(0, i), s2.Substring(0, i)) && IsScramble(s1.Substring(i), s2.Substring(i))) ||
                    (IsScramble(s1.Substring(0, i), s2.Substring(len - i)) && IsScramble(s1.Substring(i), s2.Substring(0, len - i))))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
