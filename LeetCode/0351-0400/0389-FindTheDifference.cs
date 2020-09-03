//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.7 MB
// Link: https://leetcode.com/submissions/detail/342531497/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0389_FindTheDifference
    {
        public char FindTheDifference(string s, string t)
        {
            char result = (char)0;
            foreach (var ch in s)
                result ^= ch;
            foreach (var ch in t)
                result ^= ch;

            return result;
        }
    }
}
